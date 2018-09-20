using System;

namespace Teeth.model
{
    public class Customer
    {
        public int id { get; set; }
        public String name { get; set; }
        public String adress { get; set; }
        public String phone { get; set; }
        public String email { get; set; }
        public String postNr { get; set; }

        public Customer()
        {
            
            this.id = 1;
            this.name = "default";
            this.adress = "Default Address";
            this.phone = "031-111111";
            this.email = "Default@email.com";
            this.postNr = "00000";

        }

        public Customer(int id, String name, String adress, String phone, String email, String postNr)
        {
            this.id = id;
            this.name = name;
            this.adress = adress;
            this.phone = phone;
            this.email = email;
            this.postNr = postNr;
        }

       
        
    }
}