using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackEnd.Models;

namespace BackEnd.Logic
{
    public class LogicRepo : ILogicRepo
    { 
        readonly DB context;

        public LogicRepo(DB context)
        {
            this.context = context;
        }

        public bool DeleteMahasiswa(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMateri(int id)
        {
            throw new NotImplementedException();
        }

        public bool DeleteRegisterMateri(int id)
        {
            throw new NotImplementedException();
        }

        public Mahasiswa GetMahasiswa(int id)
        {
            throw new NotImplementedException();
        }

        public Materi GetMateri(int id)
        {
            throw new NotImplementedException();
        }

        public RegisterMateri GetRegister(int id)
        {
            throw new NotImplementedException();
        }

        public List<Mahasiswa> LsMahasiswa()
        {
            throw new NotImplementedException();
        }

        public List<Materi> LsMateri()
        {
            throw new NotImplementedException();
        }

        public List<RegisterMateri> LsRegisterMateri(string RegID, string start, string lenght, string search)
        {
            throw new NotImplementedException();
        }

        public bool ModifyMahasiswa(Mahasiswa data)
        {
            throw new NotImplementedException();
        }

        public bool ModifyMateri(Materi data)
        {
            throw new NotImplementedException();
        }

        public bool ModifyRegisterMateri(RegisterMateri data)
        {
            throw new NotImplementedException();
        }
    }
}