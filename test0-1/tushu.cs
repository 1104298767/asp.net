using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test0_1
{
    class tushu
    {
        private int isbn;
        private string name;
        private int price;
        private string chubanshe;
        private string zuozhe;
        private string chubanriqi;
        public int Isbn
        {
            get { return isbn; }
            set { isbn = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Chubanshe
        {
            get { return chubanshe; }
            set { chubanshe = value; }
        }
        public string Zuozhe
        {
            get { return zuozhe; }
            set { zuozhe = value; }
        }
        public string Chubanriqi
        {
            get { return chubanriqi; }
            set { chubanriqi = value; }
        }

        public void print(){
        
            Console.WriteLine("isbn:"+ this.Isbn
                +"图书名称:"+this.Name+"单价:"+this.Price+"出版社:"+this.Chubanshe+"作者:"
                +this.Zuozhe+
                "出版日期:"+ this.Chubanriqi);
        }
        public tushu(int isbn,string name,int price,
            string chubanshe,string zuozhe,string chubanriqi){
                this.Isbn = isbn;
                this.Name = name;
                this.Price = price;
                this.Chubanshe = chubanshe;
                this.Zuozhe = zuozhe;
                this.Chubanriqi = chubanriqi;
        
        }


    }
}
