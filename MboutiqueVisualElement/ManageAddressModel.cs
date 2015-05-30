using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MboutiqueVisualElement
{
	public class ManageAddressModel
	{
		private string _address1="Address1";
		private string _address2="Address2";
		private string _country="Country";
		private string _countryPicker="Country";
		private string _state="State";
		private string _statePicker="State";
		private string _city="City";
		private string _cityPicker="City";
		private string _zip="Zip";
		private string _FindingButton="Find Location";
		private string _lattitude="Lattitude";
		private string _logitude="Logitude";
		private string _save="Save";
		private string _oldPassword="Old Password";
		private string _newPassword="New Password";
		private string _confirmPass="Confirm Password";
		private string _submitButton="Submit";
		public string Oldpass {
			get {
				return _oldPassword;
			}
			set {
				_oldPassword = value;
			}
		}
		public string NewPass {
			get {
				return _newPassword;
			}
			set {
				_newPassword = value;
			}
		}
		public string ConfirmPass {
			get {
				return _confirmPass;
			}
			set {
				_confirmPass = value;
			}
		}
		public string Submit {
			get {
				return _submitButton;
			}
			set {
				_submitButton = value;
			}
		}
		public string Address1{
			get{
				return _address1;
			}
			set{
				_address1 = value;
			}
		}
		public string Address2 {
			get {
				return _address2;
			}
			set {
				_address2 = value;
			}
		}
		public string Country{
			get{
				return _country;
			}
			set{
				_country = value;
			}
		}
		public string CountryPicker {
			get {
				return _countryPicker;
			}
			set {
				_countryPicker = value;
			}
		}
		public string State {
			get {
				return _state;
			}
			set {
				_state = value;
			}
		}
		public string StatePicker {
			get {
				return _statePicker;
			}
			set {
				_statePicker = value;
			}
		}
		public string City {
			get {
				return _city;
			}
			set {
				_cityPicker = value;
			}
		}
		public string CityPicker {
			get {
				return _cityPicker;
			}
			set {
				_cityPicker = value;
			}
		}
		public string ZIP {
			get {
				return _zip;
			}
			set {
				_zip = value;
			}
		}
		public string btnFinding {
			get {
				return _FindingButton;
			}
			set {
				_FindingButton = value;
			}
		}
		public string Lattiude {
			get {
				return _lattitude;
			}
			set {
				_lattitude = value;
			}
		}
		public string Logitude {
			get {
				return _logitude;
			}
			set {
				_logitude = value;
			}
		}
		public string Save {
			get {
				return _save;
			}
			set {
				_save = value;
			}
		}
			
	}

}


