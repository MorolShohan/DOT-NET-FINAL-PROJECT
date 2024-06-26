﻿using DAL.Interface;
using DAL.Models;
using DAL.Repos;
using DAL.Repos.DAL.Repos;
using System;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<Admin, int, Admin, String> AdminData()
        {
            return new AdminRepo();
        }

        public static SAuth<bool> AdminAuthicateeData()
        {
            return new AdminRepo();
        }

        public static InRepo<Token, string, Token> TokenData()
        {
            return new TokenRepo();
        }

        public static InRepo<Teacher, string, Teacher> InstructorData()
        {
            return new InstructorRepo();
        }

        public static IAuth<bool> AuthicateData()
        {
            return new InstructorRepo();
        }

        public static InRepo<Course, string, Course> CourseData()
        {
            return new CourseRepo();


        }

        public static SAuth<bool> AuthicateeData()
        {
            return new StudentRepo();
        }

        public static SRepo<Student, int, Student, string> StudentData()
        {
            return new StudentRepo();
        }

        public static SRepo<StudentPost, int, StudentPost, string> StudentPostData()
        {
            return new StudentPostRepo();
        }

        public static SCoRepo<Course, int, bool, int> StudentCourseData()
        {
            return new StudentCourseRepo();
        }

        public static IMRepo<StudentMgs, int, StudentMgs> StudentMgs()
        {
            return new StudentMgsRepo();

        }

        public static SRepo<StudentComment, int, StudentComment, string> StudentCommentData()
        {
            return new StudentCommentRepo();
        }

        public static IASRepo<StudentPost, int, StudentPost, AdminAgeRangeResult> APostData()
        {
            return new AdminStuPostRepoRepo();
        }

        public static IASRepo<Student, int, Student, AdminAgeRangeResult> AStudentData()
        {
            return new AdminStudentRepo();
        }

    }

}
