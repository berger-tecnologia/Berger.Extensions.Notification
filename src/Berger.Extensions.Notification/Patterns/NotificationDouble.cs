﻿using System.Linq.Expressions;
using Berger.Extensions.Abstractions;
using Berger.Extensions.Notification.Resources;

namespace Berger.Extensions.Notification
{
    public partial class Notification : INotification
    {
        /// <summary>
        /// Dado um double, adicione uma notificação se seu valor for menor que o parâmetro min
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="min">Minimum Length</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um double, adicione uma notificação se seu valor for menor que o parâmetro min</returns>
        public void IfLowerThan<T>(T model, Expression<Func<T, double>> selector, double min, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val < min)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfLowerThan.ToFormat(name, min) : message);
        }

        /// <summary>
        /// Dada um double, adicione uma notificação se seu valor for maior que o parâmetro max
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="min">Minimum Length</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada um double, adicione uma notificação se seu valor for maior que o parâmetro max</returns>
        public void IfGreaterThan<T>(T model, Expression<Func<T, double>> selector, double max, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val > max)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfGreaterThan.ToFormat(name, max) : message);
        }

        /// <summary>
        /// Dado um int, adicione uma notificação se for maior ou igual ao parametro passado
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="number">Number to be compared</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um int, adicione uma notificação se for maior ou igual ao parametro passado</returns>
        public void IfGreaterOrEqualsThan<T>(T model, Expression<Func<T, double>> selector, double number, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val >= number)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfGreaterOrEqualsThan.ToFormat(name, number) : message);
        }

        /// <summary>
        /// Dado um int, adicione uma notificação se for menor ou igual ao parametro passado
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="number">Number to be compared</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um int, adicione uma notificação se for menor ou igual ao parametro passado</returns>
        public void IfLowerOrEqualsThan<T>(T model, Expression<Func<T, double>> selector, double number, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val <= number)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfLowerOrEqualsThan.ToFormat(name, number) : message);
        }

        /// <summary>
        /// Dado um int, adicione uma notificação se não estiver entre alguns dois valores
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="a">Lower value</param>
        /// <param name="b">Higher value</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um int, adicione uma notificação se não estiver entre alguns dois valores</returns>
        public void IfNotRange<T>(T model, Expression<Func<T, double>> selector, double a, double b, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val < a || val > b)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfNotRange.ToFormat(name, a, b) : message);
        }

        /// <summary>
        /// Dado um int, adicione uma notificação se estiver entre alguns dois valores
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="a">Lower value</param>
        /// <param name="b">Higher value</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um int, adicione uma notificação se estiver entre alguns dois valores</returns>
        public void IfRange<T>(T model, Expression<Func<T, double>> selector, double a, double b, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val > a && val < b)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfRange.ToFormat(name, a, b) : message);
        }

        /// <summary>
        /// Dada uma string, adicione uma notificação se não for igual a
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="val">Value to be compared</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada uma string, adicione uma notificação se não for igual a</returns>
        public void IfNotAreEquals<T>(T model, Expression<Func<T, double>> selector, double value, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val != value)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfNotAreEquals.ToFormat(name, value) : message);
        }

        /// <summary>
        /// Dada uma string, adicione uma notificação se for igual a
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="val">Value to be compared</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada uma string, adicione uma notificação se for igual a</returns>
        public void IfAreEquals<T>(T model, Expression<Func<T, double>> selector, double value, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val == value)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfAreEquals.ToFormat(name, value) : message);
        }

        /// <summary>
        /// Dada um objeto double, adicione uma notificação se for igual null
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="val">Value to be compared</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada um objeto double, adicione uma notificação se for igual null</returns>
        public void IfNull<T>(T model, Expression<Func<T, double?>> selector, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val == null)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfNull.ToFormat(name) : message);
        }

        /// <summary>
        /// Dada um objeto double, adicione uma notificação se não for igual null
        /// </summary>
        /// <param name="selector">Nome da propriedade que deseja testar</param>
        /// <param name="val">Value to be compared</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada um objeto double, adicione uma notificação se não for igual null</returns>
        public void IfNotNull<T>(T model, Expression<Func<T, double?>> selector, string message = "")
        {
            var val = selector.Compile().Invoke(model);
            var name = ((MemberExpression)selector.Body).Member.Name;

            if (val != null)
                AddNotification(name, string.IsNullOrEmpty(message) ? Message.IfNotNull.ToFormat(name) : message);
        }

        /// <summary>
        /// Dado um double, adicione uma notificação se seu valor for menor que o parâmetro min
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="min">Minimum Length</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um double, adicione uma notificação se seu valor for menor que o parâmetro min</returns>
        public void IfLowerThan(double val, double min, string objectName, string message = "")
        {
            if (val < min)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfLowerThan.ToFormat(objectName, min) : message);
        }

        /// <summary>
        /// Dada um double, adicione uma notificação se seu valor for maior que o parâmetro max
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="min">Minimum Length</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada um double, adicione uma notificação se seu valor for maior que o parâmetro max</returns>
        public void IfGreaterThan(double val, double max, string objectName, string message = "")
        {
            if (val > max)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfGreaterThan.ToFormat(objectName, max) : message);
        }

        /// <summary>
        /// Dado um int, adicione uma notificação se for maior ou igual ao parametro passado
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="number">Number to be compared</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um int, adicione uma notificação se for maior ou igual ao parametro passado</returns>
        public void IfGreaterOrEqualsThan(double val, double number, string objectName, string message = "")
        {
            if (val >= number)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfGreaterOrEqualsThan.ToFormat(objectName, number) : message);
        }

        /// <summary>
        /// Dado um int, adicione uma notificação se for menor ou igual ao parametro passado
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="number">Number to be compared</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um int, adicione uma notificação se for menor ou igual ao parametro passado</returns>
        public void IfLowerOrEqualsThan(double val, double number, string objectName, string message = "")
        {
            if (val <= number)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfLowerOrEqualsThan.ToFormat(objectName, number) : message);
        }

        /// <summary>
        /// Dado um int, adicione uma notificação se não estiver entre alguns dois valores
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="a">Menor valor</param>
        /// <param name="b">Maior valor</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um int, adicione uma notificação se não estiver entre alguns dois valores</returns>
        public void IfNotRange(double val, double a, double b, string objectName, string message = "")
        {
            if (val < a || val > b)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfNotRange.ToFormat(objectName, a, b) : message);
        }

        /// <summary>
        /// Dado um int, adicione uma notificação se estiver entre alguns dois valores
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="a">Menor valor</param>
        /// <param name="b">Maior valor</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dado um int, adicione uma notificação se estiver entre alguns dois valores</returns>
        public void IfRange(double val, double a, double b, string objectName, string message = "")
        {
            if (val > a && val < b)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfRange.ToFormat(objectName, a, b) : message);
        }

        /// <summary>
        /// Dada uma string, adicione uma notificação se não for igual a
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="val">Valor a ser comparado</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada uma string, adicione uma notificação se não for igual a</returns>
        public void IfNotAreEquals(double val, double value, string objectName, string message = "")
        {
            if (val != value)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfNotAreEquals.ToFormat(objectName, value) : message);
        }

        /// <summary>
        /// Dada uma string, adicione uma notificação se for igual a
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="value">Valor a ser comparado</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada uma string, adicione uma notificação se for igual a</returns>
        public void IfAreEquals(double val, double value, string objectName, string message = "")
        {
            if (val == value)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfAreEquals.ToFormat(objectName, value) : message);
        }

        /// <summary>
        /// Dada um objeto double, adicione uma notificação se for igual null
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada um objeto double, adicione uma notificação se for igual null</returns>
        public void IfNull(double? val, string objectName, string message = "")
        {
            if (val == null)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfNull.ToFormat(objectName) : message);
        }

        /// <summary>
        /// Dada um objeto double, adicione uma notificação se não for igual null
        /// </summary>
        /// <param name="val">Valor informado</param>
        /// <param name="objectName">Nome da propriedade ou objeto que representa a informação</param>
        /// <param name="message">Mensagem de erro (Opcional)</param>
        /// <returns>Dada um objeto double, adicione uma notificação se não for igual null</returns>
        public void IfNotNull(double? val, string objectName, string message = "")
        {
            if (val != null)
                AddNotification(objectName, string.IsNullOrEmpty(message) ? Message.IfNotNull.ToFormat(objectName) : message);
        }
    }
}