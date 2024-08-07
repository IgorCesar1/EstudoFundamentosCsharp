namespace  Modulo11
{
        public class TrabalhandoComDatas
    {
        public void AulaDateTime()
        {
            var date1 = new DateTime(2012, 12, 02, 19, 22, 23);
            var date2 = DateTime.Parse("2022/12/22 19:25:23");
            var date3 = DateTime.Now;
            var date4 = DateTime.Today;

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);

            Console.WriteLine(date1.ToString("dd=MM-yyyy HH:mm:ss"));

            var dateOffset1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
            Console.WriteLine(dateOffset1.LocalDateTime);
            Console.WriteLine(dateOffset1.UtcDateTime);


        }

        public void AulasSubtraindoDatas()
        {
            var date1 = DateTime.Now;
            var date2 = DateTime.Parse("2022-01-01");

            //var diff = date1 - date2;
            var diff = date1.Subtract(date2);

            Console.WriteLine((int)diff.TotalDays);
            Console.WriteLine((int)diff.TotalDays);
        }

        public void AulaAdicionandoDiaMeseAno()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(date1.AddMonths(3).ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine(date1.AddYears(3).ToString("dd-MM-yyyy HH:mm:ss"));

       

        }

        public void AulaadicionandohoraminutoeSegundos()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.ToString("HH:mm:ss"));
            Console.WriteLine(date1.AddHours(1).ToString("HH:mm:ss"));
            Console.WriteLine(date1.AddMinutes(10).ToString("HH:mm:ss"));
            Console.WriteLine(date1.AddSeconds(10).ToString("HH:mm:ss"));

       
        }

        public void AulaDiaDaSemana()
        {
            var date1 = DateTime.Now;

            Console.WriteLine(date1.DayOfWeek);
       
        }

        public void AulaDateOnly()
        {
            //var somentedata = new DateOnly(2024,06,07);
            var somentedata = DateOnly.Parse("2024 -06 -07");

            Console.WriteLine(somentedata.ToString("dd/MM/yyy"));
    
        }

        public void AulaTimeOnly()
        {
            //var outraVariavel = new TimeOnly(12,23,03);
            var somentehora = TimeOnly.Parse("20:01:02");

            Console.WriteLine(somentehora.ToString("HH:mm:ss"));
    
        }



    }
}
