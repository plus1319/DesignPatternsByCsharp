using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FlyWeight.Sample2
{
    public class DepartmentRepository
    {
        public Department GetDepartments(int id)
        {
            var list = new List<Department>()
            {
                new Department{Id = 1,Name="IT"},
                new Department{Id = 2,Name="Managment"},
                new Department{Id = 3,Name="IT helpdesk"},
                new Department{Id = 4,Name="Finance"},
            };
            return list.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Dictionary<int,Department> departmentCache = new Dictionary<int, Department>();

        public Department GetDepartment(int key)
        {
            if (departmentCache.ContainsKey(key))
                return departmentCache[key];
            else
            {
                var department = GetDepartments(key);
                departmentCache.Add(key,department);
                return department;
            }
        }
    }
}
