using DatabaseActivities.Models.Entity;
using DatabaseActivities.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DatabaseActivities.Service
{
    public class StudentService
    {
        private StudentRepository repository;
        public StudentService()
        {
            repository = new StudentRepository();
        }

        public List<Student> GetAllStudents()
        {
            return repository.GetAllStudents();
        }

        public void AddStudent(Student toAdd)
        {
            repository.AddStudent(toAdd);
        }

        public Student GetStudentById(int id)
        {
            return repository.GetStudentById(id);
        }

        public void SaveEdits(Student toSave)
        {
            repository.SaveEdits(toSave);
        }

        public void DeleteStudent(Student toDelete)
        {
            repository.DeleteStudent(toDelete);
        }

        public List<Student> GetOldStudents(int age)
        {
            List < Student > students= repository.GetAllStudents();
            for(int count = students.Count-1; count>=0; count--)
            {
                if (students.ElementAt<Student>(count).age < age)
                {
                    students.RemoveAt(count);
                }
            }
            return students;
        }
    }
}