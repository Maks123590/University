﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WordInteractionLab8.Resources {
    using System;
    
    
    /// <summary>
    ///   Класс ресурса со строгой типизацией для поиска локализованных строк и т.д.
    /// </summary>
    // Этот класс создан автоматически классом StronglyTypedResourceBuilder
    // с помощью такого средства, как ResGen или Visual Studio.
    // Чтобы добавить или удалить член, измените файл .ResX и снова запустите ResGen
    // с параметром /str или перестройте свой проект VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class AppResource {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal AppResource() {
        }
        
        /// <summary>
        ///   Возвращает кэшированный экземпляр ResourceManager, использованный этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WordInteractionLab8.Resources.AppResource", typeof(AppResource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Перезаписывает свойство CurrentUICulture текущего потока для всех
        ///   обращений к ресурсу с помощью этого класса ресурса со строгой типизацией.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Data\.
        /// </summary>
        internal static string App_Data_Path {
            get {
                return ResourceManager.GetString("App_Data_Path", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Внимание.
        /// </summary>
        internal static string InfoMessageBox_Внимание {
            get {
                return ResourceManager.GetString("InfoMessageBox_Внимание", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на Все значения должны быть заполнены!.
        /// </summary>
        internal static string InfoMessageBox_Все_значения_должны_быть_заполнены_ {
            get {
                return ResourceManager.GetString("InfoMessageBox_Все_значения_должны_быть_заполнены_", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на не указывать.
        /// </summary>
        internal static string PayType_не_указывать {
            get {
                return ResourceManager.GetString("PayType_не_указывать", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на почтой.
        /// </summary>
        internal static string PayType_почтой {
            get {
                return ResourceManager.GetString("PayType_почтой", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на срочно.
        /// </summary>
        internal static string PayType_срочно {
            get {
                return ResourceManager.GetString("PayType_срочно", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на телеграфом.
        /// </summary>
        internal static string PayType_телеграфом {
            get {
                return ResourceManager.GetString("PayType_телеграфом", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Ищет локализованную строку, похожую на электронно.
        /// </summary>
        internal static string PayType_электронно {
            get {
                return ResourceManager.GetString("PayType_электронно", resourceCulture);
            }
        }
    }
}
