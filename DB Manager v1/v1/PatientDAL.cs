using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;

namespace v1
{
    internal class PatientDAL
    {
        private string _dbPath = "patients.db"; // db file and project are in same file
        private string _connectionString;

        public PatientDAL()
        {
            _connectionString = $"Data Source={_dbPath};Version=3;";

            // if db file is apsent this method ll be create
            if (!File.Exists(_dbPath))
            {
                SQLiteConnection.CreateFile(_dbPath);
                CreateTable();
            }
        }

        private void CreateTable()
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = @"
                CREATE TABLE IF NOT EXISTS Patients (
                    PatientId INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    Surname TEXT NOT NULL,
                    NationalId TEXT NOT NULL UNIQUE,
                    PhoneNumber TEXT NOT NULL,
                    Gender TEXT,
                    BloodType TEXT,
                    BirthDate TEXT NOT NULL
                );";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool Add(Patient patient)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = @"
                    INSERT INTO Patients (Name, Surname, NationalId, PhoneNumber, Gender, BloodType, BirthDate)
                    VALUES (@Name, @Surname, @NationalId, @PhoneNumber, @Gender, @BloodType, @BirthDate);";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Name", patient.Name);
                    cmd.Parameters.AddWithValue("@Surname", patient.Surname);
                    cmd.Parameters.AddWithValue("@NationalId", patient.NationalId);
                    cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                    cmd.Parameters.AddWithValue("@BloodType", patient.BloodType);
                    cmd.Parameters.AddWithValue("@BirthDate", patient.BirthDate.ToString("yyyy-MM-dd"));

                    try
                    {
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    catch (SQLiteException)
                    {
                        return false;   // if already have, return false!!!!
                    }
                }
            }
        }

        public Patient GetByNationalId(string nationalId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Patients WHERE NationalId=@NationalId;";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NationalId", nationalId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Patient
                            {
                                PatientId = Convert.ToInt32(reader["PatientId"]),
                                Name = reader["Name"].ToString(),
                                Surname = reader["Surname"].ToString(),
                                NationalId = reader["NationalId"].ToString(),
                                PhoneNumber = reader["PhoneNumber"].ToString(),
                                Gender = reader["Gender"].ToString(),
                                BloodType = reader["BloodType"].ToString(),
                                BirthDate = DateTime.Parse(reader["BirthDate"].ToString())
                            };
                        }
                        else
                        {
                            return null;
                        }
                    }
                }
            }
        }

        public List<Patient> GetAll()
        {
            var list = new List<Patient>();

            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Patients;";
                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new Patient
                        {
                            PatientId = Convert.ToInt32(reader["PatientId"]),
                            Name = reader["Name"].ToString(),
                            Surname = reader["Surname"].ToString(),
                            NationalId = reader["NationalId"].ToString(),
                            PhoneNumber = reader["PhoneNumber"].ToString(),
                            Gender = reader["Gender"].ToString(),
                            BloodType = reader["BloodType"].ToString(),
                            BirthDate = DateTime.Parse(reader["BirthDate"].ToString())
                        });
                    }
                }
            }

            return list;
        }

        public bool Update(Patient patient)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = @"
                    UPDATE Patients
                    SET Name=@Name, Surname=@Surname, PhoneNumber=@PhoneNumber,
                        Gender=@Gender, BloodType=@BloodType, BirthDate=@BirthDate
                    WHERE NationalId=@NationalId;";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NationalId", patient.NationalId);
                    cmd.Parameters.AddWithValue("@Name", patient.Name);
                    cmd.Parameters.AddWithValue("@Surname", patient.Surname);
                    cmd.Parameters.AddWithValue("@PhoneNumber", patient.PhoneNumber);
                    cmd.Parameters.AddWithValue("@Gender", patient.Gender);
                    cmd.Parameters.AddWithValue("@BloodType", patient.BloodType);
                    cmd.Parameters.AddWithValue("@BirthDate", patient.BirthDate.ToString("yyyy-MM-dd"));

                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }

        public bool Delete(string nationalId)
        {
            using (var conn = new SQLiteConnection(_connectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Patients WHERE NationalId=@NationalId;";
                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@NationalId", nationalId);
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
        }
    }
}

