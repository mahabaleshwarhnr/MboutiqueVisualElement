using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MboutiqueVisualElement
{
	public class MangaeProfileViewModel
	{
		private string _name="Name";
		private string _gender="Gender";
		private string _mobilenumber="Mobile Number";
		private string _phonenumber="Phone Number";
		private string _btnsave="Save";

		private string _dob="DOB";

		public string DOB {
			get {
				return _dob;
			}
			set {
				_dob = value;
			}
		}
		public string Name {
			get {
				return _name;
			}
			set {
				_name = value;
			}
		}
		public string Gender {
			get {
				return _gender;
			}
			set {
				_gender = value;
			}
			}
		public string MobileNumber
		{
			get {
				return _mobilenumber;
			}
			set{
				_mobilenumber = value;
			}
		}
		public string PhoneNumber {
			get {
				return _phonenumber;
			}
			set {
				_phonenumber = value;
			}
		}
		public string ButtonSave {
			get {
				return _btnsave;
			}
			set {
				_btnsave = value;
			}
		}
	}

}