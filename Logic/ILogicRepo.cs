using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BackEnd.Models;

namespace BackEnd.Logic
{
    public interface ILogicRepo
    {

        List<Mahasiswa> LsMahasiswa();
        Mahasiswa GetMahasiswa(int id);
        bool ModifyMahasiswa(Mahasiswa data);
        bool DeleteMahasiswa(int id);

        List<Materi> LsMateri();
        Materi GetMateri(int id);
        bool ModifyMateri(Materi data);
        bool DeleteMateri(int id);

        List<RegisterMateri> LsRegisterMateri(string RegID, string start, string lenght, string search);
        RegisterMateri GetRegister(int id);
        bool ModifyRegisterMateri(RegisterMateri data);
        bool DeleteRegisterMateri(int id);
    }
}
