using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WSR8
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static Entities.WSR8Entities Conxent { get; } = new Entities.WSR8Entities();
        public static Entities.User users;
        public static Entities.Product product;
    }
}
