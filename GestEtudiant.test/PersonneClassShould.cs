using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using GestEtudiants.Classe;

namespace GestEtudiant.test
{
    public class PersonneClassShould
    {
        [Fact]
        public void TestTrue()
        {
            Assert.True(3 == 5);
        }

        [Theory]
        [InlineData(4,5,9)]
        [InlineData(2,9,11)]
        [InlineData(14,5,19)]
        public void tester_somme(int val1, int val2, int expected)
        {
            Personne p = new Personne();
            int resultat = p.somme(val1, val2);
            Assert.Equal(resultat, expected);
        }
    }
}
