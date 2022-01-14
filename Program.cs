using System;
using System.Collections.Generic;

namespace Assignment_1
{
    
    public class Thanhvien{
        public String firstName{get;set;}
        public String lastName{get;set;}
        public Boolean gender;
        public int dateofBirth{get;set;}
        public String phoneNumber{get;set;}
        public String birthPlace{get;set;}
        public int age{get;set;}
        public String graduated{get;set;}
        
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            List<Thanhvien> thanhvien  = new List<Thanhvien>(){
                new Thanhvien(){
                    firstName = "Tran " , lastName = "Chi Thanh" , gender = true , 
                    dateofBirth = 2001 , phoneNumber= "0123456789" , age = 22 ,birthPlace = "Hai Phong" , graduated = "Khong"
                },
                new Thanhvien(){
                    firstName = "Tran " , lastName = "Dang Khanh" , gender = true , 
                    dateofBirth = 1999 , phoneNumber= "0974567897" , age = 23 ,birthPlace = "Ha Noi" , graduated = "Co"
                },
                new Thanhvien(){
                    firstName = "Do " , lastName = "Hong Son" , gender = true , 
                    dateofBirth = 2000 , phoneNumber= "0975378309" , age = 22 ,birthPlace = "Ha Noi" , graduated = "Khong"
                },
                
                new Thanhvien(){
                    firstName = "Phan " , lastName = "Cong Thinh" , gender = true , 
                    dateofBirth = 1999 , phoneNumber= "0974567897" , age = 23 ,birthPlace = "Ha Noi" , graduated = "Co"
                }
                
                
                
            };
            //Danh sach thanh vien nam
            Console.WriteLine("Danh sach sinh vien co gioi tinh Nam la : ");
            foreach(var p in thanhvien){
                if(p.gender == true){
                   Console.WriteLine("Full Name : " + p.firstName + p.lastName + " - Ngay sinh: " + p.dateofBirth
                   + " - So dien thoai : " + p.phoneNumber + " - Tuoi : " + p.age + " - Noi sinh : " + p.birthPlace
                   + " - Tot nghiep : " + p.graduated );
                }
            }
            //Full name
            Console.WriteLine("Danh sach thanh vien chi chua ho va ten  : ");
            foreach(var p in thanhvien){
                Console.WriteLine("Full Name : " + p.firstName + p.lastName);
            }
            //Danh sach thanh vien sinh ra tai Ha Noi
            Console.WriteLine("Thanh vien sinh ra tai Ha Noi  : ");
            foreach(var p in thanhvien){
                if(p.birthPlace == "Ha Noi"){
                    Console.WriteLine("Full Name : " + p.firstName + p.lastName);
                    break;
                }
            }
            // foreach(var p in thanhvien){
            //     p.birthPlace = "Ha Noi";
            //     while(true){
            //         Console.WriteLine("Full Name : " + p.firstName + p.lastName);
            //         if(p.birthPlace!= "Ha Noi"){
            //             break;
            //         }
            //     }
            // }
            //Max tuoi
            Console.WriteLine("Thanh vien co tuoi lon nhat : ");
            for(int i = 0 ; i < thanhvien.Count; i++){
                int max = thanhvien[0].age;
                if(thanhvien[i].age > max){
                    Console.WriteLine("Full Name : " + thanhvien[i].firstName+thanhvien[i].lastName);
                    break;
                }
                
            }
            //3 list
            
             
        }

    }
}
