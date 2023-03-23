using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shortcuts
{
    public interface IPerson
    {
        void DisplayName();
    }

    public interface IDoctor : IPerson
    {
        void Surgery();
    }

    public interface ISupplier : IPerson
    {
        void Export();
    }

    public interface IFather : IPerson
    {
        void EntertainChild();
    }

    public class Father : IFather
    {
        public void DisplayName()
        {
            throw new NotImplementedException();
        }

        public void EntertainChild()
        {
            throw new NotImplementedException();
        }
    }


    public class FatherSupplier : IFather, ISupplier
    {
        public void DisplayName()
        {
            throw new NotImplementedException();
        }

        public void EntertainChild()
        {
            throw new NotImplementedException();
        }

        public void Export()
        {
            throw new NotImplementedException();
        }
    }


    public class DoctorFather : IFather, IDoctor
    {
        public void DisplayName()
        {
            throw new NotImplementedException();
        }

        public void EntertainChild()
        {
            throw new NotImplementedException();
        }

        public void Surgery()
        {
            throw new NotImplementedException();
        }
    }



}
