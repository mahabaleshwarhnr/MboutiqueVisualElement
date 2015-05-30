using System;

using Xamarin.Forms;
using SQLite.Net.Interop;
using SQLite.Net;
using System.Diagnostics;
using System.Collections;
using System.Collections.Generic;
using Toasts.Forms.Plugin.Abstractions;
using System.Linq;


namespace MboutiqueVisualElement
{
	public class MboutiqueDatabase {
		SQLiteConnection db;

		public MboutiqueDatabase (string dbPath, ISQLitePlatform sqlitPlatform) {
			Debug.WriteLine (dbPath);
			db = new SQLiteConnection (sqlitPlatform, dbPath);
			db.CreateTable<MboutiqueData> ();
			db.CreateTable<ManageAddressData> ();
			db.CreateTable<NewUserProfileData> ();
			db.CreateTable<CatlougeData> ();
			db.CreateTable<FavouriteData> ();

			}


		public int SaveProfile (string newDate, string name, string mobileNum, string phoneNum)
		{
			return db.Insert (new MboutiqueData { Name = name, MobileNum = mobileNum, Date = newDate, PhoneNum = phoneNum });
			//Debug.WriteLine("stock is"+db.Get<ManageAddressData> (1));
		}

		public int SaveAddress (string cityName, string stateName, string countryName, string zipCode, string housename, string street)
		{
			return db.Insert (new ManageAddressData {
					CityName = cityName, StateName = stateName, CountryName = countryName, Zipcode = zipCode, Housenumber = housename, Streetname = street
				});
		}

		public int ChangeCurrentCity (string countryName, string cityName, string stateName)
		{
			//var updateString = "UPDATE ManageAddressData SET CountryName=?,StateName=?,CityName=? WHERE ID=?";
			var id = 1;
			return db.Execute ("UPDATE ManageAddressData SET CountryName=?,StateName=?,CityName=? WHERE ID=?", countryName, cityName, stateName, id);	
		}

		public void SetNewPassword (string oldPass, string newPass)
		{
			
			var userpassword = db.Query <NewUserProfileData> ("SELECT UserPassword FROM NewUserProfileData WHERE ID=?", "1");
			Debug.WriteLine (userpassword);
			//return db.Execute ("UPDATE NewUserProfileData SET UserPassword=? WHERE UserPassword=?", oldPass, newPass);

		}

		public int SaveNewUserProfile (string userName, string userPassword, string userMobileNum, string userPhone)
		{
			return db.Insert (new NewUserProfileData
					{ UserName = userName, UserPassword = userPassword, UserPhone = userPhone, UserMobileNum = userMobileNum }
			);
		}

		public int SavePickedItem (MboutiqueVisualElement catlouge, int productQuantity, int productTotal)
		{
			
			var rowCount=db.Query<CatlougeData> ("SELECT * FROM [CatlougeData]");

			var IsDuplicate = CheckForDuplicateCart (rowCount,catlouge);

				if (IsDuplicate) {
					var notificator = DependencyService.Get<IToastNotificator>();

					notificator.Notify(ToastNotificationType.Warning,"Info",catlouge.Name + "\t"+"already added to Cart",TimeSpan.FromSeconds(2));
					return 0;
				} else {
				return db.Insert (new CatlougeData {
					Name=catlouge.Name,
					Image=catlouge.Image,
					Price=catlouge.Price,
					ProductQuantity=productQuantity,
					SubTotal=productTotal
										});
	
				}


		}

		public bool CheckForDuplicateCart (List<CatlougeData> rowCount, MboutiqueVisualElement catlouge)
		{
			var result = false;
			foreach (var item in rowCount) {
				if (catlouge.Name.Equals(item.Name)) {
					result = true;
					break;
				}
			}
			return result;
		}

		public IEnumerable<CatlougeData> GetAllItems ()
		{
			return (from i in db.Table<CatlougeData>() select i).ToList();

		}

		public int GetGrandTotal ()
		{
//			db.Query<CatlougeData>("SELECT sum(SubTotal) AS Total FROM CatlougeData");
//			var GrandTotal= db.Get<CatlougeData> (1);
//			Debug.WriteLine (GrandTotal);
			int GrandTotal=0;
			var rowCount=db.Query<CatlougeData> ("SELECT * FROM [CatlougeData]");
			//var rowCount=db.Query<CatlougeData> ("SELECT sum(SubTotal) FROM [CatlougeData]");
			foreach (var item in rowCount) {
				GrandTotal =GrandTotal+ item.SubTotal;

			}
			return GrandTotal;
		}
			
		public void InsertFavourite (MboutiqueVisualElement catlouge)
		{
			
			var rowCount=db.Query<FavouriteData> ("SELECT * FROM [FavouriteData]");
			if (rowCount==null) {
				 db.Insert (new FavouriteData 
						{
							Name=catlouge.Name,
							Image=catlouge.Image,
							smallDetail=catlouge.smallDetail,
							Price=catlouge.Price

						}

				);
				var notificator = DependencyService.Get<IToastNotificator>();
				
				notificator.Notify(ToastNotificationType.Success,"Info",catlouge.Name + "\t"+"added to Favourites",TimeSpan.FromSeconds(2));

			} 
			else {

				var IsPresent = CheckForDuplicateFavourite (rowCount,catlouge);
				
				if (IsPresent) {
					var notificator = DependencyService.Get<IToastNotificator>();

					notificator.Notify(ToastNotificationType.Warning,"Info",catlouge.Name + "\t"+"already added to Favourites",TimeSpan.FromSeconds(2));

				} else {
					 db.Insert (new FavouriteData {
						Name = catlouge.Name,
						Image = catlouge.Image,
						smallDetail = catlouge.smallDetail,
						Price = catlouge.Price

					}
					);
					var notificator = DependencyService.Get<IToastNotificator>();

					notificator.Notify(ToastNotificationType.Info,"Info",catlouge.Name + "\t"+" added to Favourites",TimeSpan.FromSeconds(2));
				}

			}


		}

		public bool CheckForDuplicateFavourite (List<FavouriteData> rowCount, MboutiqueVisualElement catlouge)
		{
			var result = false;
			 foreach (var item in rowCount) {
				if (catlouge.Name.Equals(item.Name)) {
					result = true;
					break;
				}
			}
			return result;
		}



		public IEnumerable<FavouriteData> GetFavouriteItem ()
		{
			return (from i in db.Table<FavouriteData>() select i).ToList();

		}


		public string GetDeliveryAddress ()
		{
			var deliveryAddress = "";
			var rowcount=db.Query<ManageAddressData> ("SELECT * FROM [ManageAddressData]");
			foreach (var item in rowcount) {
				deliveryAddress = item.Housenumber + item.Streetname +"\n"+ "\n"+item.CityName+"\n"+item.StateName + "\n" + item.CountryName +"\n"+ item.Zipcode;

			}
			return deliveryAddress;
		}

		public int UpdateCatlougData (CatlougeData lastDeletedItem)
		{
			return db.Delete<CatlougeData> (lastDeletedItem.ID);

		}

		public int UpdateFavouriteData (FavouriteData lastFavItem)
		{
			return db.Delete<FavouriteData> (lastFavItem.ID);
		}
	}
}


