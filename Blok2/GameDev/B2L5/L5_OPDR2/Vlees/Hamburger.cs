    using System;
    namespace Vlees{
    public class Hamburger : Consturctor{
        private string name;
        private string soort;
        public Hamburger(string name, string soort): base(name, soort){
            this.name = name;
            this.soort = soort;
        }
        public string GetName(){
            return name;
        }
        public string GetSoort(){
            return soort;
        }
    }
    }