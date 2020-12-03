using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch2_observer
{
    public class WeatherData : Subject
    {
        private List<Observer> observers;

        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<Observer>();
        }

        #region Observer 인터페이스 구현

    /// <summary>
    /// 상태에 대해서 모든 옵저버에게 전달
    /// </summary>
        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.update(temperature, humidity, pressure);
            }
        }

        public void registerObserver(Observer o)
        {
            observers.Add(o);
        }

        public void removeObserver(Observer o)
        {
            bool ret = observers.Contains(o);
            if (ret == true)
            {
                observers.Remove(o);
            }
        }

        #endregion


        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
