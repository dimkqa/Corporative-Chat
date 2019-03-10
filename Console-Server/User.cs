using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Server
{
    public class User
    {
        /// <summary>
        ///     Имя пользователя
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Логин пользователя
        /// </summary>
        public string Login { get; set; }

        /// <summary>
        ///     Зашифрованный пароль пользователя
        /// </summary>
        public string Password { get; set; }
    }
}
