using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.Models;
using System.Collections.Generic;

namespace BLL.Services
{
    public class AdminService
    {
        public static AdminDTO CreateAdmin(AdminDTO adminDTO)
        {
            // Configure AutoMapper
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdminDTO, Admin>(); // Map from DTO to entity
                cfg.CreateMap<Admin, AdminDTO>(); // Map from entity to DTO
            });

            // Create mapper instance
            var mapper = new Mapper(config);

            // Map the input DTO to an entity
            var adminEntity = mapper.Map<Admin>(adminDTO);

            // Pass the mapped entity to the repository's Add method
            var addedAdminEntity = DataAccessFactory.AdminData().Add(adminEntity);

            // Map the added entity back to DTO
            var addedAdminDTO = mapper.Map<AdminDTO>(addedAdminEntity);

            // Return the DTO
            return addedAdminDTO;
        }


        public static object GetAdmin()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdminDTO, Admin>();
                cfg.CreateMap<Admin, AdminDTO>();
            });

            var mapper = new Mapper(config);
            var result = DataAccessFactory.AdminData().Get();

            var adminDTOList = mapper.Map<List<AdminDTO>>(result);
            return adminDTOList;

        }

        public static object GetAdmin(int id)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdminDTO, Admin>();
                cfg.CreateMap<Admin, AdminDTO>();
            });

            var mapper = new Mapper(config);
            var result = DataAccessFactory.AdminData().Get(id);

            var adminDTO = mapper.Map<AdminDTO>(result);
            return adminDTO;

        }

        public static StudentPostDTO GetPost(int id)
        {
            var data = DataAccessFactory.APostData().GetID(id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentPost, PostCommentDto>();
                cfg.CreateMap<StudentComment, StudentCommentDTO>();
            });

            var mapper = new Mapper(config);

            var postDTOs = mapper.Map<PostCommentDto>(data);
            return postDTOs;
        }

        public static List<StudentPostDTO> GetApprovePosts()
        {
            var data = DataAccessFactory.APostData().Read();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentPost, StudentPostDTO>();
            });

            var mapper = new Mapper(config);

            var postDTOs = mapper.Map<List<StudentPostDTO>>(data);
            return postDTOs;
        }

        public static List<StudentPostDTO> GetNotApprovePosts()
        {
            var data = DataAccessFactory.APostData().NotApprove();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentPost, StudentPostDTO>();
            });

            var mapper = new Mapper(config);

            var postDTOs = mapper.Map<List<StudentPostDTO>>(data);
            return postDTOs;
        }

        public static bool DeletePost(int id)
        {
            var dataAccess = DataAccessFactory.APostData();
            return dataAccess.Delete(id);
        }

        public static StudentPostDTO UpdatePostApproval(int id)
        {
            var dataAccess = DataAccessFactory.APostData();
            var updatedEntity = dataAccess.Update(id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<StudentPost, StudentPostDTO>();
            });

            var mapper = new Mapper(config);

            var updatedDTO = mapper.Map<StudentPostDTO>(updatedEntity);
            return updatedDTO;
        }

        public static List<PostCountDto> GetPostRange()
        {
            var dataAccess = DataAccessFactory.APostData();
            var data = dataAccess.ReadMonthly();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdminAgeRangeResult, PostCountDto>();
            });

            var mapper = new Mapper(config);

            var mappedData = mapper.Map<List<AdminAgeRangeResult>, List<PostCountDto>>(data);

            return mappedData;
        }

        public static StudentDTO GetStudent(int id)
        {
            var data = DataAccessFactory.AStudentData().GetID(id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();

            });

            var mapper = new Mapper(config);

            var postDTOs = mapper.Map<StudentDTO>(data);
            return postDTOs;
        }

        public static StudentDTO UpdateStudentApproval(int id)
        {
            var dataAccess = DataAccessFactory.AStudentData();
            var updatedEntity = dataAccess.Update(id);

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Student, StudentDTO>();
            });

            var mapper = new Mapper(config);

            var updatedDTO = mapper.Map<StudentDTO>(updatedEntity);
            return updatedDTO;
        }

        public static List<RengeDTO> GetStudentAgeRange()
        {
            var dataAccess = DataAccessFactory.AStudentData();
            var data = dataAccess.ReadMonthly();

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<AdminAgeRangeResult, RengeDTO>();
            });

            var mapper = new Mapper(config);

            var mappedData = mapper.Map<List<AdminAgeRangeResult>, List<RengeDTO>>(data);

            return mappedData;
        }




    }





}

