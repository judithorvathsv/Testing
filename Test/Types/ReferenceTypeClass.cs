using First3;

using NUnit.Framework;

namespace Test.Types
{

    class ReferenceTypeClass
    {

       
        public void StringCOmp()
        {
            string name1 = "Scott";
            string name2 = "scott";

            bool result = string.Equals(name1, name2, System.StringComparison.InvariantCultureIgnoreCase);
          //  Assert.IsTrue(result);
         //   Assert.IsFalse(result);
        }

       public void InVarHoldValue()
        {
            int x1 = 100;
            int x2 = x1;

            x1 = 4;
          //  Assert.AreNotEqual(x1, x2);
            Assert.AreEqual(x1, x2);
        }

        public void VariableHold() {
            GradeBook g1 = new GradeBook();
            GradeBook g2 = g1;

            g1 = new GradeBook();
            g1.Name = "Scott";
            g2.Name = "Dave";
          //  Assert.AreEqual(g1.Name, g2.Name);
      

        }
    }
}
