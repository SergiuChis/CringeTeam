﻿using CringeProject.Entities;
using CringeProject.Entities.UserTypes;
using CringeProject.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CringeProject {
    public partial class LoginWindow : Form {
        public LoginWindow() {
            InitializeComponent();
        }

        private void LoginWindow_Load(object sender, EventArgs e) {
            using (var ctx = new RepositoryContext()) {
                var stud = new User("Bill", "password", new ListenerType());

                ctx.Users.Add(stud);
                ctx.SaveChanges();

                var stud2 = new Section { AvailablePlaces = 2, Room = "Room1" };
                var paper = new Paper { User = stud, Section = stud2, Abstract = "a", Body = "c" };

                ctx.Sections.Add(stud2);
                ctx.Papers.Add(paper);
                ctx.SaveChanges();

                stud = new User("clinton", "pass", new ProgramCommitteeMemberType());
                paper = new Paper { Abstract = "a", Body = "c", User = stud };

                ctx.Users.Add(stud);
                ctx.Papers.Add(paper);
                ctx.SaveChanges();
            }
        }
    }
}
