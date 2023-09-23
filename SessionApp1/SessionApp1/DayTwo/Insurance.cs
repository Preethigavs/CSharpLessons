using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SessionApp1.DayTwo
{
    internal class Insurance
    {
        public int MemberId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Title { get; set; } = string.Empty;

        public string Gender { get; set; } = string.Empty;
        public string Height { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;

        public string BloodGroup { get; set; } = string.Empty;


        public string Description { get; set; } = string.Empty;
        public string NomineeName { get; set; } = string.Empty;

        public string NomineeRelationship { get; set; } = string.Empty;

        public string BankName { get; set; } = string.Empty;

        public string Address { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Region { get; set; } = string.Empty;
        public string PostalCode { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; }

        public override string ToString()
        {
            return $"MemberID: {this.MemberId},\n Name:{Title} {FirstName} {LastName},\nGender: {Gender},\n Height: {Height},\nWeight: {Weight}\n, BloodGroup: {BloodGroup}\n"  +
                $"Address:  {Address},\nCity: {City},\n Region: {Region}\n " +
                $"Phone :{Phone},\nEmail : {Email},\nCountry: {Country},\n Zip: {PostalCode},\n NomineeName: {NomineeName},\nNomineeRelationship: {NomineeRelationship}\n, BankName: {BankName}";
        }
    }

    internal class TestInsurance
    {
        public static void TestOne()
        {
            Insurance insurance = new Insurance();
            insurance.MemberId = 10001;
            insurance.FirstName = "Preethi";
            insurance.LastName = "Srinivasan";
            insurance.Gender = "Female";
            insurance.Height = "170cm";
            insurance.Weight = "70kg";
            insurance.BloodGroup = "B+ve";
            insurance.Address = "Omalur";
            insurance.City = "Salem";
            insurance.Region = "Salem";
            insurance.PostalCode = "12345";
            insurance.Country = "India";
            insurance.Phone = "9012340260";
            insurance.Email = "hello1234@gmail.com";
            insurance.NomineeName = "Devi";
            insurance.NomineeRelationship = "Mother";
            insurance.BankName = "HDFC";
            insurance.Title = "Ms. ";
            String data = insurance.ToString();
            Console.WriteLine(data);
        }
    }
}
