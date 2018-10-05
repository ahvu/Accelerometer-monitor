using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolViewAccel
{
    public struct AccelerometerData
    {
        const double gravity = 1;
        public static double scale = 2;
        public static double samplingRate = 400;

        public double ax, ay, az;
        public AccelerometerData(sbyte _ax, sbyte _ay, sbyte _az)
        {
            ax = ConvertAccelData(_ax);
            ay = ConvertAccelData(_ay);
            az = ConvertAccelData(_az);
        }
        public AccelerometerData(double _ax, double _ay, double _az)
        {
            ax = _ax;
            ay = _ay;
            az = _az;
        }
        public static double ConvertAccelData(sbyte _ax)
        {
            return (double)(_ax) / 128 * gravity * scale;
        }

        public override bool Equals(Object obj)
        {
            return obj is AccelerometerData && Equals((AccelerometerData)obj);
        }

        public bool Equals(AccelerometerData other)
        {
            return ax == other.ax && ay == other.ay && az == other.az;
        }

        public static bool operator ==(AccelerometerData lhs, AccelerometerData rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(AccelerometerData lhs, AccelerometerData rhs)
        {
            return !lhs.Equals(rhs);
        }

        public static AccelerometerData operator -(AccelerometerData a, AccelerometerData b)
        {
            return new AccelerometerData(a.ax - b.ax, a.ay - b.ay, a.az - b.az);
        }

        public static AccelerometerData operator *(double d, AccelerometerData accData)
        {
            return new AccelerometerData(d*accData.ax, d*accData.ay, d*accData.az);
        }
    }

    public struct Accel_Register
    {        
        public string name;
        public byte address;
        public byte value;

        public Accel_Register(string _name, byte _address, byte _value)
        {
            name = _name;
            address = _address;
            value = _value;
        }
    }

    public struct ODR_Setting
    {
         public int rate;
         public byte reg_val;
         public ODR_Setting(int _rate, byte _reg_val)
         {
            rate = _rate;
            reg_val = _reg_val;
         }
    }
}
