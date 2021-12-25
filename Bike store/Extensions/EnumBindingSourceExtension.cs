using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

//For binding enums to combobox. so we dont have to keep repeating the WPF method in XAML
namespace Bike_store
{
    class EnumBindingSourceExtension : MarkupExtension
    {
        public Type EnumType { get; private set; }

        public EnumBindingSourceExtension(Type enumtype)
        {
            if (enumtype is null || !enumtype.IsEnum)
                throw new Exception("EnumType must not be null en be an enum");

            EnumType = enumtype;
        }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return Enum.GetValues(EnumType);
        }
    }
}
