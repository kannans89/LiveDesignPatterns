using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePatternApp.Model
{
    internal class Rectangle :ClonePrototypeBase<Rectangle>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public string Color { get; set; }

        public Point Point { get; set; }

        public Rectangle() {
            Console.WriteLine("inside constructor of rectangle");
        }
        //public Object Clone()
        //{
        //    //var copy = new Rectangle();
        //    //copy.Width = Width;
        //    //copy.Height = Height;
        //    //copy.Color = Color;

        //    //return copy;

        //    return this.MemberwiseClone();
        //}

        //public Object CloneDeepCopy() {

        //    string result = JsonConvert.SerializeObject(this);
        //    return JsonConvert.DeserializeObject<Rectangle>(result);

        //}

        public override string ToString()
        {
            
            return $"Width is {this.Width} Hieght is {this.Height} Color {this.Color}";
              
        }

    }
}
