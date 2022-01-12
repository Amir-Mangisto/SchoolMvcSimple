using SchoolMvc.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SchoolMvc.Controllers
{
    public class StuController : ApiController
    {
        Student[] stuArray = new Student[] { new Student(1, "dolev", "haziza", 40), new Student(2, "Maor", "Azili", 20), new Student(3, "john", "hugo", 30) };
        List<Student> stuList = new List<Student>();
    
        // GET: api/Stu
        public IHttpActionResult Get()
        {
            try
            {
                stuList.AddRange(stuArray);
                return Ok(new { stu = stuList });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // GET: api/Stu/5
        public IHttpActionResult Get(int id)
        {
            try
            {
                stuList.AddRange(stuArray);
                Student student = stuList.Find(x => x.Id == id);
                return Ok(new { stu = student });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // POST: api/Stu
        public IHttpActionResult Post([FromBody] Student studentUser)
        {
            try
            {
                stuList.AddRange(stuArray);
                stuList.Add(studentUser);
                return Ok(new { add = stuList });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // PUT: api/Stu/5
        public IHttpActionResult Put(int id, [FromBody] Student value)
        {
            try
            {
                stuList.AddRange(stuArray);

                foreach (Student student in stuArray)
                {
                    if (student.Id == id)
                    {
                        student.FirstName = value.FirstName;
                        student.LastName = value.LastName;
                        student.Age = value.Age;
                        return Ok(new { stuList });
                    }
                }
                return Ok(new { Mess = "TRY AGAIN" });

            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }

        // DELETE: api/Stu/5
        public IHttpActionResult Delete(int id)
        {
            try
            {
                stuList.AddRange(stuArray);
                stuList.Remove(stuList.Find(stu => stu.Id == id));
                return Ok(new { stuList });
            }
            catch (SqlException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception err)
            {
                return BadRequest(err.Message);
            }
        }
    }
}
