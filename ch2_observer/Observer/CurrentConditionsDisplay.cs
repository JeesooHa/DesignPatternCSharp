using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_observer
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        private float temperature;
        private float humidity;
        private Subject weatherData;


        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }


        public void display()
        {
            Console.WriteLine("Current confitions: " + temperature + "F degrees and " +
                humidity + "% humidity");
        }


        // 데이터를 화면에 표시하는 방법은 다른 식으로 디자인 하는 것이 더 좋음
        // => 모델-뷰-컨트롤러 패턴
        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            display();
        }
    }
}
