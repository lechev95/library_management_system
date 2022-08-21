namespace library_management_system.FORMS
{
    partial class ManageCirculationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Lbl_Circulation = new System.Windows.Forms.Label();
            this.Btn_Close = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Btn_Return = new System.Windows.Forms.Button();
            this.Btn_Issue = new System.Windows.Forms.Button();
            this.panelIssue = new System.Windows.Forms.Panel();
            this.Btn_IssueBook = new System.Windows.Forms.Button();
            this.Btn_SearchMember = new System.Windows.Forms.Button();
            this.Btn_SearchBook = new System.Windows.Forms.Button();
            this.Rtb_Note = new System.Windows.Forms.RichTextBox();
            this.Dtp_Return = new System.Windows.Forms.DateTimePicker();
            this.Dtp_Issue = new System.Windows.Forms.DateTimePicker();
            this.Lbl_Note = new System.Windows.Forms.Label();
            this.Lbl_ReturnDate = new System.Windows.Forms.Label();
            this.Lbl_IssueDate = new System.Windows.Forms.Label();
            this.Lbl_YesOrNo = new System.Windows.Forms.Label();
            this.Lbl_BookAvailable = new System.Windows.Forms.Label();
            this.Lbl_MemberFullName = new System.Windows.Forms.Label();
            this.Lbl_BookTitle = new System.Windows.Forms.Label();
            this.Nud_MemberId = new System.Windows.Forms.NumericUpDown();
            this.Lbl_MemberId = new System.Windows.Forms.Label();
            this.Nud_BookId = new System.Windows.Forms.NumericUpDown();
            this.Lbl_BookId = new System.Windows.Forms.Label();
            this.panelReturn = new System.Windows.Forms.Panel();
            this.Dgv_IssuedBooks = new System.Windows.Forms.DataGridView();
            this.Btn_Delete = new System.Windows.Forms.Button();
            this.Btn_BookLost = new System.Windows.Forms.Button();
            this.Btn_ReturnBook = new System.Windows.Forms.Button();
            this.Rtb_RetNote = new System.Windows.Forms.RichTextBox();
            this.Dtp_RetReturnDate = new System.Windows.Forms.DateTimePicker();
            this.Dtp_RetIssueDate = new System.Windows.Forms.DateTimePicker();
            this.Lbl_RetNote = new System.Windows.Forms.Label();
            this.Lbl_RetReturnDate = new System.Windows.Forms.Label();
            this.Lbl_RetIssueDate = new System.Windows.Forms.Label();
            this.Lbl_RetMemberFullName = new System.Windows.Forms.Label();
            this.Lbl_RetBookTitle = new System.Windows.Forms.Label();
            this.Nud_RetMemberId = new System.Windows.Forms.NumericUpDown();
            this.Lbl_RetMemberId = new System.Windows.Forms.Label();
            this.Nud_RetBookId = new System.Windows.Forms.NumericUpDown();
            this.Lbl_RetBookId = new System.Windows.Forms.Label();
            this.Btn_Issued = new System.Windows.Forms.Button();
            this.Btn_Returned = new System.Windows.Forms.Button();
            this.Btn_Lost = new System.Windows.Forms.Button();
            this.Btn_All = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelIssue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_MemberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_BookId)).BeginInit();
            this.panelReturn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_IssuedBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_RetMemberId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_RetBookId)).BeginInit();
            this.SuspendLayout();
            // 
            // Lbl_Circulation
            // 
            this.Lbl_Circulation.BackColor = System.Drawing.SystemColors.Info;
            this.Lbl_Circulation.Dock = System.Windows.Forms.DockStyle.Top;
            this.Lbl_Circulation.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Circulation.Location = new System.Drawing.Point(0, 0);
            this.Lbl_Circulation.Name = "Lbl_Circulation";
            this.Lbl_Circulation.Size = new System.Drawing.Size(1264, 78);
            this.Lbl_Circulation.TabIndex = 5;
            this.Lbl_Circulation.Text = "Circulation";
            this.Lbl_Circulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Btn_Close
            // 
            this.Btn_Close.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Close.FlatAppearance.BorderSize = 0;
            this.Btn_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Close.Location = new System.Drawing.Point(1234, 0);
            this.Btn_Close.Name = "Btn_Close";
            this.Btn_Close.Size = new System.Drawing.Size(30, 30);
            this.Btn_Close.TabIndex = 7;
            this.Btn_Close.UseVisualStyleBackColor = false;
            this.Btn_Close.Click += new System.EventHandler(this.Btn_Close_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel2.Controls.Add(this.Btn_Return);
            this.panel2.Controls.Add(this.Btn_Issue);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 78);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 555);
            this.panel2.TabIndex = 8;
            // 
            // Btn_Return
            // 
            this.Btn_Return.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Return.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Return.FlatAppearance.BorderSize = 0;
            this.Btn_Return.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Return.Location = new System.Drawing.Point(12, 89);
            this.Btn_Return.Name = "Btn_Return";
            this.Btn_Return.Size = new System.Drawing.Size(173, 80);
            this.Btn_Return.TabIndex = 9;
            this.Btn_Return.Text = "Return";
            this.Btn_Return.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Return.UseVisualStyleBackColor = false;
            this.Btn_Return.Click += new System.EventHandler(this.Btn_Return_Click);
            // 
            // Btn_Issue
            // 
            this.Btn_Issue.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Issue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Issue.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Issue.FlatAppearance.BorderSize = 0;
            this.Btn_Issue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Issue.Location = new System.Drawing.Point(12, 3);
            this.Btn_Issue.Name = "Btn_Issue";
            this.Btn_Issue.Size = new System.Drawing.Size(173, 80);
            this.Btn_Issue.TabIndex = 8;
            this.Btn_Issue.Text = "Issue";
            this.Btn_Issue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Issue.UseVisualStyleBackColor = false;
            this.Btn_Issue.Click += new System.EventHandler(this.Btn_Issue_Click);
            // 
            // panelIssue
            // 
            this.panelIssue.Controls.Add(this.Btn_IssueBook);
            this.panelIssue.Controls.Add(this.Btn_SearchMember);
            this.panelIssue.Controls.Add(this.Btn_SearchBook);
            this.panelIssue.Controls.Add(this.Rtb_Note);
            this.panelIssue.Controls.Add(this.Dtp_Return);
            this.panelIssue.Controls.Add(this.Dtp_Issue);
            this.panelIssue.Controls.Add(this.Lbl_Note);
            this.panelIssue.Controls.Add(this.Lbl_ReturnDate);
            this.panelIssue.Controls.Add(this.Lbl_IssueDate);
            this.panelIssue.Controls.Add(this.Lbl_YesOrNo);
            this.panelIssue.Controls.Add(this.Lbl_BookAvailable);
            this.panelIssue.Controls.Add(this.Lbl_MemberFullName);
            this.panelIssue.Controls.Add(this.Lbl_BookTitle);
            this.panelIssue.Controls.Add(this.Nud_MemberId);
            this.panelIssue.Controls.Add(this.Lbl_MemberId);
            this.panelIssue.Controls.Add(this.Nud_BookId);
            this.panelIssue.Controls.Add(this.Lbl_BookId);
            this.panelIssue.Location = new System.Drawing.Point(206, 81);
            this.panelIssue.Name = "panelIssue";
            this.panelIssue.Size = new System.Drawing.Size(1046, 540);
            this.panelIssue.TabIndex = 9;
            // 
            // Btn_IssueBook
            // 
            this.Btn_IssueBook.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_IssueBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_IssueBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_IssueBook.FlatAppearance.BorderSize = 0;
            this.Btn_IssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_IssueBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_IssueBook.Location = new System.Drawing.Point(367, 479);
            this.Btn_IssueBook.Name = "Btn_IssueBook";
            this.Btn_IssueBook.Size = new System.Drawing.Size(356, 43);
            this.Btn_IssueBook.TabIndex = 47;
            this.Btn_IssueBook.Text = "Issue Book";
            this.Btn_IssueBook.UseVisualStyleBackColor = false;
            this.Btn_IssueBook.Click += new System.EventHandler(this.Btn_IssueBook_Click);
            // 
            // Btn_SearchMember
            // 
            this.Btn_SearchMember.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_SearchMember.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SearchMember.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_SearchMember.FlatAppearance.BorderSize = 0;
            this.Btn_SearchMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SearchMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_SearchMember.Location = new System.Drawing.Point(487, 108);
            this.Btn_SearchMember.Name = "Btn_SearchMember";
            this.Btn_SearchMember.Size = new System.Drawing.Size(200, 33);
            this.Btn_SearchMember.TabIndex = 46;
            this.Btn_SearchMember.Text = "Search Member";
            this.Btn_SearchMember.UseVisualStyleBackColor = false;
            this.Btn_SearchMember.Click += new System.EventHandler(this.Btn_SearchMember_Click);
            // 
            // Btn_SearchBook
            // 
            this.Btn_SearchBook.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_SearchBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_SearchBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_SearchBook.FlatAppearance.BorderSize = 0;
            this.Btn_SearchBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_SearchBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_SearchBook.Location = new System.Drawing.Point(487, 20);
            this.Btn_SearchBook.Name = "Btn_SearchBook";
            this.Btn_SearchBook.Size = new System.Drawing.Size(200, 33);
            this.Btn_SearchBook.TabIndex = 45;
            this.Btn_SearchBook.Text = "Search Book";
            this.Btn_SearchBook.UseVisualStyleBackColor = false;
            this.Btn_SearchBook.Click += new System.EventHandler(this.Btn_SearchBook_Click);
            // 
            // Rtb_Note
            // 
            this.Rtb_Note.Location = new System.Drawing.Point(323, 341);
            this.Rtb_Note.Name = "Rtb_Note";
            this.Rtb_Note.Size = new System.Drawing.Size(400, 119);
            this.Rtb_Note.TabIndex = 44;
            this.Rtb_Note.Text = "";
            // 
            // Dtp_Return
            // 
            this.Dtp_Return.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_Return.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_Return.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Return.Location = new System.Drawing.Point(323, 291);
            this.Dtp_Return.Name = "Dtp_Return";
            this.Dtp_Return.Size = new System.Drawing.Size(200, 38);
            this.Dtp_Return.TabIndex = 43;
            // 
            // Dtp_Issue
            // 
            this.Dtp_Issue.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_Issue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_Issue.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_Issue.Location = new System.Drawing.Point(323, 230);
            this.Dtp_Issue.Name = "Dtp_Issue";
            this.Dtp_Issue.Size = new System.Drawing.Size(200, 38);
            this.Dtp_Issue.TabIndex = 42;
            // 
            // Lbl_Note
            // 
            this.Lbl_Note.AutoSize = true;
            this.Lbl_Note.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_Note.Location = new System.Drawing.Point(229, 341);
            this.Lbl_Note.Name = "Lbl_Note";
            this.Lbl_Note.Size = new System.Drawing.Size(82, 32);
            this.Lbl_Note.TabIndex = 41;
            this.Lbl_Note.Text = "Note:";
            // 
            // Lbl_ReturnDate
            // 
            this.Lbl_ReturnDate.AutoSize = true;
            this.Lbl_ReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_ReturnDate.Location = new System.Drawing.Point(137, 285);
            this.Lbl_ReturnDate.Name = "Lbl_ReturnDate";
            this.Lbl_ReturnDate.Size = new System.Drawing.Size(174, 32);
            this.Lbl_ReturnDate.TabIndex = 40;
            this.Lbl_ReturnDate.Text = "Return Date:";
            // 
            // Lbl_IssueDate
            // 
            this.Lbl_IssueDate.AutoSize = true;
            this.Lbl_IssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_IssueDate.Location = new System.Drawing.Point(155, 231);
            this.Lbl_IssueDate.Name = "Lbl_IssueDate";
            this.Lbl_IssueDate.Size = new System.Drawing.Size(156, 32);
            this.Lbl_IssueDate.TabIndex = 39;
            this.Lbl_IssueDate.Text = "Issue Date:";
            // 
            // Lbl_YesOrNo
            // 
            this.Lbl_YesOrNo.AutoSize = true;
            this.Lbl_YesOrNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_YesOrNo.Location = new System.Drawing.Point(317, 178);
            this.Lbl_YesOrNo.Name = "Lbl_YesOrNo";
            this.Lbl_YesOrNo.Size = new System.Drawing.Size(144, 32);
            this.Lbl_YesOrNo.TabIndex = 38;
            this.Lbl_YesOrNo.Text = "Yes Or No";
            // 
            // Lbl_BookAvailable
            // 
            this.Lbl_BookAvailable.AutoSize = true;
            this.Lbl_BookAvailable.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_BookAvailable.Location = new System.Drawing.Point(10, 180);
            this.Lbl_BookAvailable.Name = "Lbl_BookAvailable";
            this.Lbl_BookAvailable.Size = new System.Drawing.Size(301, 32);
            this.Lbl_BookAvailable.TabIndex = 37;
            this.Lbl_BookAvailable.Text = "Is This Book Available:";
            // 
            // Lbl_MemberFullName
            // 
            this.Lbl_MemberFullName.AutoSize = true;
            this.Lbl_MemberFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_MemberFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_MemberFullName.Location = new System.Drawing.Point(320, 143);
            this.Lbl_MemberFullName.Name = "Lbl_MemberFullName";
            this.Lbl_MemberFullName.Size = new System.Drawing.Size(177, 25);
            this.Lbl_MemberFullName.TabIndex = 36;
            this.Lbl_MemberFullName.Text = "Member Full Name";
            this.Lbl_MemberFullName.Click += new System.EventHandler(this.Lbl_MemberFullName_Click);
            this.Lbl_MemberFullName.MouseEnter += new System.EventHandler(this.Lbl_MemberFullName_MouseEnter);
            this.Lbl_MemberFullName.MouseLeave += new System.EventHandler(this.Lbl_MemberFullName_MouseLeave);
            // 
            // Lbl_BookTitle
            // 
            this.Lbl_BookTitle.AutoSize = true;
            this.Lbl_BookTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_BookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_BookTitle.Location = new System.Drawing.Point(320, 55);
            this.Lbl_BookTitle.Name = "Lbl_BookTitle";
            this.Lbl_BookTitle.Size = new System.Drawing.Size(99, 25);
            this.Lbl_BookTitle.TabIndex = 35;
            this.Lbl_BookTitle.Text = "Book Title";
            this.Lbl_BookTitle.Click += new System.EventHandler(this.Lbl_BookTitle_Click);
            this.Lbl_BookTitle.MouseEnter += new System.EventHandler(this.Lbl_BookTitle_MouseEnter);
            this.Lbl_BookTitle.MouseLeave += new System.EventHandler(this.Lbl_BookTitle_MouseLeave);
            // 
            // Nud_MemberId
            // 
            this.Nud_MemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nud_MemberId.Location = new System.Drawing.Point(325, 110);
            this.Nud_MemberId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nud_MemberId.Name = "Nud_MemberId";
            this.Nud_MemberId.Size = new System.Drawing.Size(156, 30);
            this.Nud_MemberId.TabIndex = 34;
            // 
            // Lbl_MemberId
            // 
            this.Lbl_MemberId.AutoSize = true;
            this.Lbl_MemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_MemberId.Location = new System.Drawing.Point(152, 111);
            this.Lbl_MemberId.Name = "Lbl_MemberId";
            this.Lbl_MemberId.Size = new System.Drawing.Size(159, 32);
            this.Lbl_MemberId.TabIndex = 33;
            this.Lbl_MemberId.Text = "Member ID:";
            // 
            // Nud_BookId
            // 
            this.Nud_BookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nud_BookId.Location = new System.Drawing.Point(325, 22);
            this.Nud_BookId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nud_BookId.Name = "Nud_BookId";
            this.Nud_BookId.Size = new System.Drawing.Size(156, 30);
            this.Nud_BookId.TabIndex = 32;
            // 
            // Lbl_BookId
            // 
            this.Lbl_BookId.AutoSize = true;
            this.Lbl_BookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_BookId.Location = new System.Drawing.Point(190, 22);
            this.Lbl_BookId.Name = "Lbl_BookId";
            this.Lbl_BookId.Size = new System.Drawing.Size(121, 32);
            this.Lbl_BookId.TabIndex = 31;
            this.Lbl_BookId.Text = "Book ID:";
            // 
            // panelReturn
            // 
            this.panelReturn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelReturn.Controls.Add(this.Btn_All);
            this.panelReturn.Controls.Add(this.Btn_Lost);
            this.panelReturn.Controls.Add(this.Btn_Returned);
            this.panelReturn.Controls.Add(this.Btn_Issued);
            this.panelReturn.Controls.Add(this.Dgv_IssuedBooks);
            this.panelReturn.Controls.Add(this.Btn_Delete);
            this.panelReturn.Controls.Add(this.Btn_BookLost);
            this.panelReturn.Controls.Add(this.Btn_ReturnBook);
            this.panelReturn.Controls.Add(this.Rtb_RetNote);
            this.panelReturn.Controls.Add(this.Dtp_RetReturnDate);
            this.panelReturn.Controls.Add(this.Dtp_RetIssueDate);
            this.panelReturn.Controls.Add(this.Lbl_RetNote);
            this.panelReturn.Controls.Add(this.Lbl_RetReturnDate);
            this.panelReturn.Controls.Add(this.Lbl_RetIssueDate);
            this.panelReturn.Controls.Add(this.Lbl_RetMemberFullName);
            this.panelReturn.Controls.Add(this.Lbl_RetBookTitle);
            this.panelReturn.Controls.Add(this.Nud_RetMemberId);
            this.panelReturn.Controls.Add(this.Lbl_RetMemberId);
            this.panelReturn.Controls.Add(this.Nud_RetBookId);
            this.panelReturn.Controls.Add(this.Lbl_RetBookId);
            this.panelReturn.Location = new System.Drawing.Point(206, 81);
            this.panelReturn.Name = "panelReturn";
            this.panelReturn.Size = new System.Drawing.Size(1046, 540);
            this.panelReturn.TabIndex = 48;
            // 
            // Dgv_IssuedBooks
            // 
            this.Dgv_IssuedBooks.AllowUserToAddRows = false;
            this.Dgv_IssuedBooks.AllowUserToDeleteRows = false;
            this.Dgv_IssuedBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_IssuedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_IssuedBooks.Location = new System.Drawing.Point(425, 50);
            this.Dgv_IssuedBooks.Name = "Dgv_IssuedBooks";
            this.Dgv_IssuedBooks.RowHeadersWidth = 51;
            this.Dgv_IssuedBooks.RowTemplate.Height = 24;
            this.Dgv_IssuedBooks.Size = new System.Drawing.Size(592, 410);
            this.Dgv_IssuedBooks.TabIndex = 50;
            this.Dgv_IssuedBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_IssuedBooks_CellClick);
            // 
            // Btn_Delete
            // 
            this.Btn_Delete.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Delete.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Delete.FlatAppearance.BorderSize = 0;
            this.Btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Delete.Location = new System.Drawing.Point(696, 479);
            this.Btn_Delete.Name = "Btn_Delete";
            this.Btn_Delete.Size = new System.Drawing.Size(321, 43);
            this.Btn_Delete.TabIndex = 49;
            this.Btn_Delete.Text = "Delete";
            this.Btn_Delete.UseVisualStyleBackColor = false;
            this.Btn_Delete.Click += new System.EventHandler(this.Btn_Delete_Click);
            // 
            // Btn_BookLost
            // 
            this.Btn_BookLost.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_BookLost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_BookLost.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_BookLost.FlatAppearance.BorderSize = 0;
            this.Btn_BookLost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_BookLost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_BookLost.Location = new System.Drawing.Point(356, 479);
            this.Btn_BookLost.Name = "Btn_BookLost";
            this.Btn_BookLost.Size = new System.Drawing.Size(321, 43);
            this.Btn_BookLost.TabIndex = 48;
            this.Btn_BookLost.Text = "Book Lost";
            this.Btn_BookLost.UseVisualStyleBackColor = false;
            this.Btn_BookLost.Click += new System.EventHandler(this.Btn_BookLost_Click);
            // 
            // Btn_ReturnBook
            // 
            this.Btn_ReturnBook.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_ReturnBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ReturnBook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_ReturnBook.FlatAppearance.BorderSize = 0;
            this.Btn_ReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_ReturnBook.Location = new System.Drawing.Point(16, 479);
            this.Btn_ReturnBook.Name = "Btn_ReturnBook";
            this.Btn_ReturnBook.Size = new System.Drawing.Size(321, 43);
            this.Btn_ReturnBook.TabIndex = 47;
            this.Btn_ReturnBook.Text = "Return Book";
            this.Btn_ReturnBook.UseVisualStyleBackColor = false;
            this.Btn_ReturnBook.Click += new System.EventHandler(this.Btn_ReturnBook_Click);
            // 
            // Rtb_RetNote
            // 
            this.Rtb_RetNote.Location = new System.Drawing.Point(196, 337);
            this.Rtb_RetNote.Name = "Rtb_RetNote";
            this.Rtb_RetNote.Size = new System.Drawing.Size(200, 119);
            this.Rtb_RetNote.TabIndex = 44;
            this.Rtb_RetNote.Text = "";
            // 
            // Dtp_RetReturnDate
            // 
            this.Dtp_RetReturnDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_RetReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_RetReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_RetReturnDate.Location = new System.Drawing.Point(196, 287);
            this.Dtp_RetReturnDate.Name = "Dtp_RetReturnDate";
            this.Dtp_RetReturnDate.Size = new System.Drawing.Size(200, 38);
            this.Dtp_RetReturnDate.TabIndex = 43;
            // 
            // Dtp_RetIssueDate
            // 
            this.Dtp_RetIssueDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_RetIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Dtp_RetIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_RetIssueDate.Location = new System.Drawing.Point(196, 226);
            this.Dtp_RetIssueDate.Name = "Dtp_RetIssueDate";
            this.Dtp_RetIssueDate.Size = new System.Drawing.Size(200, 38);
            this.Dtp_RetIssueDate.TabIndex = 42;
            // 
            // Lbl_RetNote
            // 
            this.Lbl_RetNote.AutoSize = true;
            this.Lbl_RetNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_RetNote.Location = new System.Drawing.Point(102, 337);
            this.Lbl_RetNote.Name = "Lbl_RetNote";
            this.Lbl_RetNote.Size = new System.Drawing.Size(82, 32);
            this.Lbl_RetNote.TabIndex = 41;
            this.Lbl_RetNote.Text = "Note:";
            // 
            // Lbl_RetReturnDate
            // 
            this.Lbl_RetReturnDate.AutoSize = true;
            this.Lbl_RetReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_RetReturnDate.Location = new System.Drawing.Point(10, 281);
            this.Lbl_RetReturnDate.Name = "Lbl_RetReturnDate";
            this.Lbl_RetReturnDate.Size = new System.Drawing.Size(174, 32);
            this.Lbl_RetReturnDate.TabIndex = 40;
            this.Lbl_RetReturnDate.Text = "Return Date:";
            // 
            // Lbl_RetIssueDate
            // 
            this.Lbl_RetIssueDate.AutoSize = true;
            this.Lbl_RetIssueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_RetIssueDate.Location = new System.Drawing.Point(28, 227);
            this.Lbl_RetIssueDate.Name = "Lbl_RetIssueDate";
            this.Lbl_RetIssueDate.Size = new System.Drawing.Size(156, 32);
            this.Lbl_RetIssueDate.TabIndex = 39;
            this.Lbl_RetIssueDate.Text = "Issue Date:";
            // 
            // Lbl_RetMemberFullName
            // 
            this.Lbl_RetMemberFullName.AutoSize = true;
            this.Lbl_RetMemberFullName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_RetMemberFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_RetMemberFullName.Location = new System.Drawing.Point(65, 138);
            this.Lbl_RetMemberFullName.Name = "Lbl_RetMemberFullName";
            this.Lbl_RetMemberFullName.Size = new System.Drawing.Size(151, 20);
            this.Lbl_RetMemberFullName.TabIndex = 36;
            this.Lbl_RetMemberFullName.Text = "Member Full Name";
            // 
            // Lbl_RetBookTitle
            // 
            this.Lbl_RetBookTitle.AutoSize = true;
            this.Lbl_RetBookTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Lbl_RetBookTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_RetBookTitle.Location = new System.Drawing.Point(65, 50);
            this.Lbl_RetBookTitle.Name = "Lbl_RetBookTitle";
            this.Lbl_RetBookTitle.Size = new System.Drawing.Size(84, 20);
            this.Lbl_RetBookTitle.TabIndex = 35;
            this.Lbl_RetBookTitle.Text = "Book Title";
            // 
            // Nud_RetMemberId
            // 
            this.Nud_RetMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nud_RetMemberId.Location = new System.Drawing.Point(198, 106);
            this.Nud_RetMemberId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nud_RetMemberId.Name = "Nud_RetMemberId";
            this.Nud_RetMemberId.ReadOnly = true;
            this.Nud_RetMemberId.Size = new System.Drawing.Size(156, 30);
            this.Nud_RetMemberId.TabIndex = 34;
            // 
            // Lbl_RetMemberId
            // 
            this.Lbl_RetMemberId.AutoSize = true;
            this.Lbl_RetMemberId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_RetMemberId.Location = new System.Drawing.Point(25, 107);
            this.Lbl_RetMemberId.Name = "Lbl_RetMemberId";
            this.Lbl_RetMemberId.Size = new System.Drawing.Size(159, 32);
            this.Lbl_RetMemberId.TabIndex = 33;
            this.Lbl_RetMemberId.Text = "Member ID:";
            // 
            // Nud_RetBookId
            // 
            this.Nud_RetBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Nud_RetBookId.Location = new System.Drawing.Point(198, 18);
            this.Nud_RetBookId.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Nud_RetBookId.Name = "Nud_RetBookId";
            this.Nud_RetBookId.ReadOnly = true;
            this.Nud_RetBookId.Size = new System.Drawing.Size(156, 30);
            this.Nud_RetBookId.TabIndex = 32;
            // 
            // Lbl_RetBookId
            // 
            this.Lbl_RetBookId.AutoSize = true;
            this.Lbl_RetBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Lbl_RetBookId.Location = new System.Drawing.Point(63, 18);
            this.Lbl_RetBookId.Name = "Lbl_RetBookId";
            this.Lbl_RetBookId.Size = new System.Drawing.Size(121, 32);
            this.Lbl_RetBookId.TabIndex = 31;
            this.Lbl_RetBookId.Text = "Book ID:";
            // 
            // Btn_Issued
            // 
            this.Btn_Issued.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Issued.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Issued.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Issued.FlatAppearance.BorderSize = 0;
            this.Btn_Issued.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Issued.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Issued.Location = new System.Drawing.Point(425, 12);
            this.Btn_Issued.Name = "Btn_Issued";
            this.Btn_Issued.Size = new System.Drawing.Size(118, 32);
            this.Btn_Issued.TabIndex = 10;
            this.Btn_Issued.Text = "Issued";
            this.Btn_Issued.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Issued.UseVisualStyleBackColor = false;
            this.Btn_Issued.Click += new System.EventHandler(this.Btn_Issued_Click);
            // 
            // Btn_Returned
            // 
            this.Btn_Returned.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Returned.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Returned.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Returned.FlatAppearance.BorderSize = 0;
            this.Btn_Returned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Returned.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Returned.Location = new System.Drawing.Point(580, 12);
            this.Btn_Returned.Name = "Btn_Returned";
            this.Btn_Returned.Size = new System.Drawing.Size(118, 32);
            this.Btn_Returned.TabIndex = 51;
            this.Btn_Returned.Text = "Returned";
            this.Btn_Returned.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Returned.UseVisualStyleBackColor = false;
            this.Btn_Returned.Click += new System.EventHandler(this.Btn_Returned_Click);
            // 
            // Btn_Lost
            // 
            this.Btn_Lost.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_Lost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Lost.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_Lost.FlatAppearance.BorderSize = 0;
            this.Btn_Lost.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Lost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_Lost.Location = new System.Drawing.Point(735, 12);
            this.Btn_Lost.Name = "Btn_Lost";
            this.Btn_Lost.Size = new System.Drawing.Size(118, 32);
            this.Btn_Lost.TabIndex = 52;
            this.Btn_Lost.Text = "Lost";
            this.Btn_Lost.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_Lost.UseVisualStyleBackColor = false;
            this.Btn_Lost.Click += new System.EventHandler(this.Btn_Lost_Click);
            // 
            // Btn_All
            // 
            this.Btn_All.BackColor = System.Drawing.SystemColors.Info;
            this.Btn_All.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_All.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Btn_All.FlatAppearance.BorderSize = 0;
            this.Btn_All.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Btn_All.Location = new System.Drawing.Point(890, 12);
            this.Btn_All.Name = "Btn_All";
            this.Btn_All.Size = new System.Drawing.Size(118, 32);
            this.Btn_All.TabIndex = 53;
            this.Btn_All.Text = "All";
            this.Btn_All.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn_All.UseVisualStyleBackColor = false;
            this.Btn_All.Click += new System.EventHandler(this.Btn_All_Click);
            // 
            // ManageCirculationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1264, 633);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Btn_Close);
            this.Controls.Add(this.Lbl_Circulation);
            this.Controls.Add(this.panelReturn);
            this.Controls.Add(this.panelIssue);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCirculationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageCirculationForm";
            this.Load += new System.EventHandler(this.ManageCirculationForm_Load);
            this.panel2.ResumeLayout(false);
            this.panelIssue.ResumeLayout(false);
            this.panelIssue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_MemberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_BookId)).EndInit();
            this.panelReturn.ResumeLayout(false);
            this.panelReturn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_IssuedBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_RetMemberId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_RetBookId)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Lbl_Circulation;
        private System.Windows.Forms.Button Btn_Close;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Btn_Return;
        private System.Windows.Forms.Button Btn_Issue;
        private System.Windows.Forms.Panel panelIssue;
        private System.Windows.Forms.RichTextBox Rtb_Note;
        private System.Windows.Forms.DateTimePicker Dtp_Return;
        private System.Windows.Forms.DateTimePicker Dtp_Issue;
        private System.Windows.Forms.Label Lbl_Note;
        private System.Windows.Forms.Label Lbl_ReturnDate;
        private System.Windows.Forms.Label Lbl_IssueDate;
        private System.Windows.Forms.Label Lbl_YesOrNo;
        private System.Windows.Forms.Label Lbl_BookAvailable;
        private System.Windows.Forms.Label Lbl_MemberFullName;
        private System.Windows.Forms.Label Lbl_BookTitle;
        private System.Windows.Forms.NumericUpDown Nud_MemberId;
        private System.Windows.Forms.Label Lbl_MemberId;
        private System.Windows.Forms.NumericUpDown Nud_BookId;
        private System.Windows.Forms.Label Lbl_BookId;
        private System.Windows.Forms.Button Btn_SearchMember;
        private System.Windows.Forms.Button Btn_SearchBook;
        private System.Windows.Forms.Button Btn_IssueBook;
        private System.Windows.Forms.Panel panelReturn;
        private System.Windows.Forms.Button Btn_ReturnBook;
        private System.Windows.Forms.RichTextBox Rtb_RetNote;
        private System.Windows.Forms.DateTimePicker Dtp_RetReturnDate;
        private System.Windows.Forms.DateTimePicker Dtp_RetIssueDate;
        private System.Windows.Forms.Label Lbl_RetNote;
        private System.Windows.Forms.Label Lbl_RetReturnDate;
        private System.Windows.Forms.Label Lbl_RetIssueDate;
        private System.Windows.Forms.Label Lbl_RetMemberFullName;
        private System.Windows.Forms.Label Lbl_RetBookTitle;
        private System.Windows.Forms.NumericUpDown Nud_RetMemberId;
        private System.Windows.Forms.Label Lbl_RetMemberId;
        private System.Windows.Forms.NumericUpDown Nud_RetBookId;
        private System.Windows.Forms.Label Lbl_RetBookId;
        private System.Windows.Forms.DataGridView Dgv_IssuedBooks;
        private System.Windows.Forms.Button Btn_Delete;
        private System.Windows.Forms.Button Btn_BookLost;
        private System.Windows.Forms.Button Btn_Lost;
        private System.Windows.Forms.Button Btn_Returned;
        private System.Windows.Forms.Button Btn_Issued;
        private System.Windows.Forms.Button Btn_All;
    }
}