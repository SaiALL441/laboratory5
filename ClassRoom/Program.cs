using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoom
{
    public class Pupil
    {
        public string Name 
        {
            get;
            private set;
        }

        public Pupil(string name)
        {
            Name = name;
        }

        private string PupilStatus()
        {
            return String.Format("{0} {1}", GetType().Name, Name);
        }
        public virtual void Study()
        {
            Console.WriteLine("{0} {1}", PupilStatus(), "Studying");
        }
        public virtual void Read()
        {
            Console.WriteLine("{0} {1}", PupilStatus(), "Reading");
        }

        public virtual void Write()
        {
            Console.WriteLine("{0} {1}", PupilStatus(), "Writting");
        }

        public virtual void Relax()
        {
            Console.WriteLine("{0} {1}", PupilStatus(), "Relaxing");
        }
    }


        public class ExellentPupil : Pupil
        {
            public ExellentPupil(string name)
                : base(name)
            { }
            public override void Study()
            {
                Console.WriteLine("{0} understands the whole program", Name);
            }
            public override void Read()
            {
                Console.WriteLine("{0} reads a lot", Name);
            }
            public override void Write()
            {
                Console.WriteLine("{0} writes without errors", Name);
            }

            public override void Relax()
            {
                Console.WriteLine("{0} correct daily schedule", Name);
            }
        }


        public class GoodPupil : Pupil
        {
            public GoodPupil(string name)
                : base(name)
            { }
        public override void Study()
        {
            Console.WriteLine("{0} understands almost all program", Name);
        }
        public override void Read()
        {
            Console.WriteLine("{0} reads more than others", Name);
        }
        public override void Write()
        {
            Console.WriteLine("{0} may be errors", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("{0} good relax", Name);
        }
        }

        public class BadPupil : Pupil
        {
            public BadPupil(string name)
                : base(name)
            { }
        public override void Study()
        {
            Console.WriteLine("{0} doesn't understand the program", Name);
        }
        public override void Read()
        {
            Console.WriteLine("{0} reads little", Name);
        }
        public override void Write()
        {
            Console.WriteLine("{0} writes with errors", Name);
        }

        public override void Relax()
        {
            Console.WriteLine("{0} bad schedule", Name);
        }
        }

        public class ClassRoom
        {
            public readonly List<Pupil> Pupils = new List<Pupil>();
        
        public ClassRoom(params Pupil[] pupils)
            {
                Pupils.AddRange(pupils);
            }
        public void GetPupilsWrite()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
            }
        }
       

    }
    class Program
    {
        static void Main(string[] args)
        {

            Pupil mary = new ExellentPupil("Mary");
            Pupil oksana = new GoodPupil("Oksana");
            Pupil alex = new BadPupil("Alex");
            Pupil mark = new GoodPupil("Mark");



            var classall = new ClassRoom(alex, oksana, mary, mark);

            classall.GetPupilsWrite();
            Console.ReadLine();
        }
    }


}
