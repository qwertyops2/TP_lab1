using System;
using System.Collections.Generic;
using System.Text;

using Magazine.Core.Models;

namespace Magazine.Core.Services
{
    public interface IProductService
    {
        /// <summary>
        /// Добавляет новый продукт в систему
        /// </summary>
        /// <param name="product">Объект продукта, содержащий данные для добавления (название, цена, описание и т.д.)</param>
        /// <returns>Добавленный продукт с присвоенным идентификатором</returns>
        Product add(Product product);

        /// <summary>
        /// Удаляет продукт из системы по его идентификатору
        /// </summary>
        /// <param name="id">Уникальный идентификатор (GUID) продукта, который необходимо удалить</param>
        /// <returns>Удалённый продукт. Если продукт с указанным id не найден, возвращает null</returns>
        Product remove(Guid id);

        /// <summary>
        /// Редактирует существующий продукт
        /// </summary>
        /// <param name="product">Объект продукта с обновлёнными данными. Поле Id обязательно для идентификации редактируемого продукта</param>
        /// <returns>Отредактированный продукт с применёнными изменениями</returns>
        Product edit(Product product);

        /// <summary>
        /// Выполняет поиск продукта по его идентификатору
        /// </summary>
        /// <param name="id">Уникальный идентификатор (GUID) продукта для поиска</param>
        /// <returns>Найденный продукт, либо null если продукт с указанным id не существует</returns>
        Product? search(Guid id);
    }
}