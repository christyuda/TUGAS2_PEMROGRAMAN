using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204025
{
    public class DVD_1204025 : Product_1204025
    {
        protected string duration;

        public DVD_1204025(string title, string duration){
            this.MyTitle = title;
            this.duration = duration;
            this.MyType = "DVD";
        }

        public string Duration{
            get {
                return  this.duration;
            }
            set{
                duration = value;
            }
        }
    }
    }