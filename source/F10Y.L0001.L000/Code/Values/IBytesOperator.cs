using System;

using F10Y.T0003;


namespace F10Y.L0001.L000
{
    [ValuesMarker]
    public partial interface IBytesOperator
    {
        double Get_Gibibytes_AsDouble(long value)
        {
            var value_asDouble = Instances.Converter.To_Double(value);
            var gibi_AsDouble = Instances.Converter.To_Double(Instances.Values.Gibi);

            var output = value_asDouble / gibi_AsDouble;
            return output;
        }

        double Get_Gibibytes_AsDouble(ulong value)
        {
            var value_asDouble = Instances.Converter.To_Double(value);
            var gibi_AsDouble = Instances.Converter.To_Double(Instances.Values.Gibi);

            var output = value_asDouble / gibi_AsDouble;
            return output;
        }

        ulong Get_Gibibytes_AsUlong(ulong value)
        {
            var gibi_AsUlong = Instances.Converter.To_Ulong(Instances.Values.Gibi);

            var output = value / gibi_AsUlong;
            return output;
        }

        double Get_Gigabytes_AsDouble(long value)
        {
            var value_asDouble = Instances.Converter.To_Double(value);
            var gibi_AsDouble = Instances.Converter.To_Double(Instances.Values.Giga);

            var output = value_asDouble / gibi_AsDouble;
            return output;
        }

        ulong Get_Gigabytes_AsUlong(ulong value)
        {
            var giga_AsUlong = Instances.Converter.To_Ulong(Instances.Values.Giga);

            var output = value / giga_AsUlong;
            return output;
        }
    }
}
