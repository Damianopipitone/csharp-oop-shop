using System.Dynamic;

namespace shop
{
    public class Product
    {   
        //ATTRIBUTI 
        public string name;
        public int code;
        public string description;
        float price;
        int IVA;
        
        
        //COSTRUTTORE
        public Product(string name, int code, string description, float price, int IVA)
        {
            this.name = name;
            this.code = code;
            this.description = description;
            this.price = price;
            this.IVA = IVA;
        }
        //METODI   
        public string nameProduct()
        {
            return "Il nostro prodotto si chiama " + name;

        }
        
        public int codeProduct()
        {
            return code;
        }

        public string descriptionProduct()
        {
            return description;
        }

        public float priceProduct()
        {
            return price;
        }

        public int IVAProduct()
        {
            return IVA;
        }
        public void setName (string name)
        {
            this.name = name; 
        }
    }
}
