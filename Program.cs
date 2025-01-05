
        Console.WriteLine("inserisci il raggio del cerchio che vuoi calcolare:");
        string number=Console.ReadLine();
        bool isDouble =double.TryParse(number,out double numberDouble);
        if(isDouble){
            double area = numberDouble*numberDouble*Math.PI;
            Console.WriteLine(area); 
            float areaFloat= (float)area;
            Console.WriteLine(areaFloat); 
            decimal areaDecimal=(decimal)area;
             Console.WriteLine(areaDecimal);
        }
       