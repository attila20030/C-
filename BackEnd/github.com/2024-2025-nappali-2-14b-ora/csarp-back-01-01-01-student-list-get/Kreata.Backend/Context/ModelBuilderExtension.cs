﻿using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Datas.Enums;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Kreata.Backend.Context
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            List<Student> students = new List<Student>
            {
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="János",
                    LastName="Jegy",
                    BirthsDay=new DateTime(2022,10,10),
                    SchoolYear=9,
                    SchoolClass = SchoolClassType.ClassA,
                    EducationLevel="érettségi"
                },
                new Student
                {
                    Id=Guid.NewGuid(),
                    FirstName="Szonja",
                    LastName="Stréber",
                    BirthsDay=new DateTime(2021,4,4),
                    SchoolYear=10,
                    SchoolClass = SchoolClassType.ClassB,
                    EducationLevel="érettségi"
                }
    };
            List<Teacher> teachers = new()
            {
                new Teacher
                {
                    Id= Guid.NewGuid(),
                    FirstName="Feri",
                    LastName="Földrajz",
                    BirthsDay=new DateTime(2010,10,10),
                    IsWoomen=false,
                    IsHeadTeacher=false,
                },
                new Teacher
                {
                    Id= Guid.NewGuid(),
                    FirstName="Bori",
                    LastName="Biológia",
                    BirthsDay=new DateTime(2005,5,5),
                    IsWoomen=true,
                    IsHeadTeacher=true,
                },
            };


            List<Parent> parents = new()
            {
                new Parent
                {
                    Id= Guid.NewGuid(),
                    FirstName="Lilla",
                    LastName="Dakó",
                },
                new Parent
                {
                    Id= Guid.NewGuid(),
                    FirstName="Bodrogi",
                    LastName="István",
                },
            };
            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Teacher>().HasData(teachers);
            modelBuilder.Entity<Parent>().HasData(parents);
        }
    }
}
