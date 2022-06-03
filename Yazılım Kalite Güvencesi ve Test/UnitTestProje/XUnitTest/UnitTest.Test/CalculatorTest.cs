using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTest.APP;
using Xunit;

namespace UnitTest.Test
{
    public class CalculatorTest
    {
        [Fact]
        public void AddTest()
        {
            /*
            1) Arrange

            2) Act
            
            3) Assert
                Her zaman ilk olarak ne beklendiği yazılır daha sonra ise gelen değer nedir o yazılır.
                Tüm metodları 2 değer alırlar.
                    --Contains = Beklenen değer ve gelen değer içinde var mı testi
                        **Kadir geçmesini istediğimiz değer ve Kadir GÜRBÜZ eğerki gelen değerse içinde Kadir vardır ve test başarılıdır.
                    --DoesNotContains = Contains ile aynıdır sadece burada sağlanmamsı halinde test başarılıdır.
                
             */

            ////Arrange
            //int a = 5;
            //int b = 20;

            //var calculator = new Calculator();

            ////Act
            //var total = calculator.add(a,b);

            ////Assert
            //--Equal = gelen sayısal değerler eşit mi ?
            //Assert.Equal<int>(25,total);

            //--Contains = İçeriyor mu? demektir.
            //Assert.Contains("Kadir","Kadir GÜRBÜZ");

            //--DoesNotContain = İçermiyor mu? demektir.
            //Assert.DoesNotContain("deneme","burası sağlamamaktadır");

            //Bir listenin içerisinde istenilen değer varmı diye böyle kontrol ederiz.
            //var names = new List<string>() { "Kadir", "deneme", "felan filan" };
            //Assert.Contains(names,x=>x=="deneme");

            //--True-False
            //Doğru olan sonuçlar için True test başarılıdır.
            Assert.True(5>2);

            //Yanlış olan sonuçlar için False test başarılıdır.
            Assert.False(5<2);

            //Tip karşılaştırması
            Assert.True("".GetType()==typeof(string));

            //--Match-DoesNotMatch = regex ifadesini alır eğer sağlıyor ise true döner
            var regEx = "^dog";//başında dog olsun sonrası ne olursa olsun başka yerde olursa false döner
            Assert.Matches(regEx,"dog fight");
            Assert.DoesNotMatch(regEx,"fight dog");//başında dog yok ve sağlamama kontrolü başarılı olur.


            

        
        
        }
    }
}
