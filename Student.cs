using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_OOP_03
{
    internal class Student
    {
       private string _name;
       private string _id;
       private int _birthYear;
       private int _hight;
       private double _grade;
       private string _branch;
       private int _age;

        public string Name
        {
            get { return this._name; }
        }
        public string ID
        {
            get { return this._id; }
        }
        public int Birthyear
        {
            get { return this._birthYear; }
        }
        public int Hight
        {
            get { return this._hight; }
        }
        public double Grade
        {
            get { return this._grade; }
        }
        public string Branch
        {
            get { return this._branch; }
        }
        //constructor
        public Student(string name , string id , int birthYear , int hight , double grade , string branch)
        {
            this._name = name;
            this._id = id;
            this._birthYear = birthYear;
            this._hight = hight;
            this._grade = grade;
            this._branch = branch;
            
        }
    
        
    }
}
