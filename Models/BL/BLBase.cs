using CoreMVC.Models.DL;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace CoreMVC.Models.BL
{
    public class BLBase<T>
    {
        protected DLBase<T> dl;
        public BLBase()
        {
            dl = new DLBase<T>();
        }
        /// <summary>
        /// Lấy về entity theo ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T GetByID(int id)
        {
            return dl.GetByID(id);
        }

        /// <summary>
        /// Lấy dữ liệu phân trang
        /// </summary>
        /// <returns></returns>
        public List<T> GetPaging()
        {
            throw new Exception();
        }

        /// <summary>
        /// Lấy toàn bộ
        /// </summary>
        /// <returns></returns>
        public List<T> GetAll()
        {
            return dl.GetAll();
        }

        /// <summary>
        /// Thêm 1 entity
        /// </summary>
        public bool Insert(T entity)
        {
            return dl.Insert(entity);
        }

        /// <summary>
        /// Sửa 1 entity
        /// </summary>
        public void Update()
        {
            throw new Exception();
        }

        /// <summary>
        /// Xóa một entity
        /// </summary>
        public void Delete()
        {
            throw new Exception();
        }
    }
}
