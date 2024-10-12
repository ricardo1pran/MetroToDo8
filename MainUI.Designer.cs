namespace MetroToDo
{
    partial class MainUI
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
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.styleManager1 = new MetroSet_UI.Components.StyleManager();
            this.mainTabs = new MetroSet_UI.Controls.MetroSetTabControl();
            this.mainToDo = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btn_edittodo = new MetroSet_UI.Controls.MetroSetButton();
            this.btn_deltodo = new MetroSet_UI.Controls.MetroSetButton();
            this.btn_complete = new MetroSet_UI.Controls.MetroSetButton();
            this.todoDevider = new MetroSet_UI.Controls.MetroSetDivider();
            this.tb_todoInput = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btn_addTodo = new MetroSet_UI.Controls.MetroSetButton();
            this.lb_todo1 = new MetroSet_UI.Controls.MetroSetListBox();
            this.completedToDos = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.prefpanel = new MetroSet_UI.Child.MetroSetSetTabPage();
            this.mtd_helper = new MetroSet_UI.Controls.MetroSetLabel();
            this.mainTabs.SuspendLayout();
            this.mainToDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.Silver;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(569, 10);
            this.metroSetControlBox1.MaximizeBox = false;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetControlBox1.StyleManager = this.styleManager1;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroDark";
            // 
            // styleManager1
            // 
            this.styleManager1.CustomTheme = "C:\\Users\\Ricardo Gunawan\\AppData\\Roaming\\Microsoft\\Windows\\Templates\\ThemeFile.xm" +
    "l";
            this.styleManager1.MetroForm = this;
            this.styleManager1.Style = MetroSet_UI.Enums.Style.Dark;
            this.styleManager1.ThemeAuthor = "Narwin";
            this.styleManager1.ThemeName = "MetroDark";
            // 
            // mainTabs
            // 
            this.mainTabs.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.mainTabs.AnimateTime = 200;
            this.mainTabs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainTabs.Controls.Add(this.mainToDo);
            this.mainTabs.Controls.Add(this.completedToDos);
            this.mainTabs.Controls.Add(this.prefpanel);
            this.mainTabs.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainTabs.IsDerivedStyle = true;
            this.mainTabs.ItemSize = new System.Drawing.Size(100, 38);
            this.mainTabs.Location = new System.Drawing.Point(15, 98);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.SelectedTextColor = System.Drawing.Color.White;
            this.mainTabs.Size = new System.Drawing.Size(654, 388);
            this.mainTabs.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.mainTabs.Speed = 100;
            this.mainTabs.Style = MetroSet_UI.Enums.Style.Dark;
            this.mainTabs.StyleManager = this.styleManager1;
            this.mainTabs.TabIndex = 1;
            this.mainTabs.ThemeAuthor = "Narwin";
            this.mainTabs.ThemeName = "MetroDark";
            this.mainTabs.UnselectedTextColor = System.Drawing.Color.Gray;
            this.mainTabs.UseAnimation = false;
            // 
            // mainToDo
            // 
            this.mainToDo.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainToDo.Controls.Add(this.metroSetLabel2);
            this.mainToDo.Controls.Add(this.metroSetLabel1);
            this.mainToDo.Controls.Add(this.btn_edittodo);
            this.mainToDo.Controls.Add(this.btn_deltodo);
            this.mainToDo.Controls.Add(this.btn_complete);
            this.mainToDo.Controls.Add(this.todoDevider);
            this.mainToDo.Controls.Add(this.tb_todoInput);
            this.mainToDo.Controls.Add(this.btn_addTodo);
            this.mainToDo.Controls.Add(this.lb_todo1);
            this.mainToDo.Font = null;
            this.mainToDo.ImageIndex = 0;
            this.mainToDo.ImageKey = null;
            this.mainToDo.IsDerivedStyle = true;
            this.mainToDo.Location = new System.Drawing.Point(4, 42);
            this.mainToDo.Name = "mainToDo";
            this.mainToDo.Size = new System.Drawing.Size(646, 342);
            this.mainToDo.Style = MetroSet_UI.Enums.Style.Dark;
            this.mainToDo.StyleManager = this.styleManager1;
            this.mainToDo.TabIndex = 0;
            this.mainToDo.Text = "ToDo List";
            this.mainToDo.ThemeAuthor = "Narwin";
            this.mainToDo.ThemeName = "MetroDark";
            this.mainToDo.ToolTipText = null;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Segoe WP Light", 10F);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(465, 3);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 7;
            this.metroSetLabel2.Text = "Add To Do";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroDark";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Segoe WP Light", 10F);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(465, 127);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(100, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Dark;
            this.metroSetLabel1.StyleManager = this.styleManager1;
            this.metroSetLabel1.TabIndex = 7;
            this.metroSetLabel1.Text = "Manage To Do";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroDark";
            // 
            // btn_edittodo
            // 
            this.btn_edittodo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_edittodo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_edittodo.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_edittodo.Font = new System.Drawing.Font("Segoe WP Light", 10F);
            this.btn_edittodo.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_edittodo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_edittodo.HoverTextColor = System.Drawing.Color.White;
            this.btn_edittodo.IsDerivedStyle = true;
            this.btn_edittodo.Location = new System.Drawing.Point(465, 191);
            this.btn_edittodo.Name = "btn_edittodo";
            this.btn_edittodo.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_edittodo.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_edittodo.NormalTextColor = System.Drawing.Color.White;
            this.btn_edittodo.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_edittodo.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_edittodo.PressTextColor = System.Drawing.Color.White;
            this.btn_edittodo.Size = new System.Drawing.Size(180, 32);
            this.btn_edittodo.Style = MetroSet_UI.Enums.Style.Custom;
            this.btn_edittodo.StyleManager = null;
            this.btn_edittodo.TabIndex = 6;
            this.btn_edittodo.Text = "Edit ToDo!";
            this.btn_edittodo.ThemeAuthor = "Narwin";
            this.btn_edittodo.ThemeName = "MetroDark";
            this.btn_edittodo.Click += new System.EventHandler(this.btn_edittodo_Click);
            // 
            // btn_deltodo
            // 
            this.btn_deltodo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_deltodo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_deltodo.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_deltodo.Font = new System.Drawing.Font("Segoe WP Light", 10F);
            this.btn_deltodo.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_deltodo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_deltodo.HoverTextColor = System.Drawing.Color.White;
            this.btn_deltodo.IsDerivedStyle = true;
            this.btn_deltodo.Location = new System.Drawing.Point(465, 229);
            this.btn_deltodo.Name = "btn_deltodo";
            this.btn_deltodo.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_deltodo.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_deltodo.NormalTextColor = System.Drawing.Color.White;
            this.btn_deltodo.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_deltodo.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_deltodo.PressTextColor = System.Drawing.Color.White;
            this.btn_deltodo.Size = new System.Drawing.Size(180, 32);
            this.btn_deltodo.Style = MetroSet_UI.Enums.Style.Custom;
            this.btn_deltodo.StyleManager = null;
            this.btn_deltodo.TabIndex = 5;
            this.btn_deltodo.Text = "Delete ToDo";
            this.btn_deltodo.ThemeAuthor = "Narwin";
            this.btn_deltodo.ThemeName = "MetroDark";
            this.btn_deltodo.Click += new System.EventHandler(this.btn_deltodo_Click);
            // 
            // btn_complete
            // 
            this.btn_complete.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_complete.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_complete.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_complete.Font = new System.Drawing.Font("Segoe WP Light", 10F);
            this.btn_complete.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_complete.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_complete.HoverTextColor = System.Drawing.Color.White;
            this.btn_complete.IsDerivedStyle = true;
            this.btn_complete.Location = new System.Drawing.Point(465, 153);
            this.btn_complete.Name = "btn_complete";
            this.btn_complete.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_complete.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_complete.NormalTextColor = System.Drawing.Color.White;
            this.btn_complete.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_complete.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_complete.PressTextColor = System.Drawing.Color.White;
            this.btn_complete.Size = new System.Drawing.Size(180, 32);
            this.btn_complete.Style = MetroSet_UI.Enums.Style.Custom;
            this.btn_complete.StyleManager = null;
            this.btn_complete.TabIndex = 4;
            this.btn_complete.Text = "Complete ToDo";
            this.btn_complete.ThemeAuthor = "Narwin";
            this.btn_complete.ThemeName = "MetroDark";
            this.btn_complete.Click += new System.EventHandler(this.btn_complete_Click);
            // 
            // todoDevider
            // 
            this.todoDevider.IsDerivedStyle = true;
            this.todoDevider.Location = new System.Drawing.Point(466, 111);
            this.todoDevider.Name = "todoDevider";
            this.todoDevider.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.todoDevider.Size = new System.Drawing.Size(180, 4);
            this.todoDevider.Style = MetroSet_UI.Enums.Style.Dark;
            this.todoDevider.StyleManager = this.styleManager1;
            this.todoDevider.TabIndex = 3;
            this.todoDevider.Text = "metroSetDivider1";
            this.todoDevider.ThemeAuthor = "Narwin";
            this.todoDevider.ThemeName = "MetroDark";
            this.todoDevider.Thickness = 1;
            // 
            // tb_todoInput
            // 
            this.tb_todoInput.AutoCompleteCustomSource = null;
            this.tb_todoInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tb_todoInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tb_todoInput.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(110)))), ((int)(((byte)(110)))));
            this.tb_todoInput.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.tb_todoInput.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_todoInput.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tb_todoInput.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_todoInput.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.tb_todoInput.Image = null;
            this.tb_todoInput.IsDerivedStyle = true;
            this.tb_todoInput.Lines = null;
            this.tb_todoInput.Location = new System.Drawing.Point(466, 29);
            this.tb_todoInput.MaxLength = 32767;
            this.tb_todoInput.Multiline = false;
            this.tb_todoInput.Name = "tb_todoInput";
            this.tb_todoInput.ReadOnly = false;
            this.tb_todoInput.Size = new System.Drawing.Size(180, 33);
            this.tb_todoInput.Style = MetroSet_UI.Enums.Style.Dark;
            this.tb_todoInput.StyleManager = this.styleManager1;
            this.tb_todoInput.TabIndex = 2;
            this.tb_todoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_todoInput.ThemeAuthor = "Narwin";
            this.tb_todoInput.ThemeName = "MetroDark";
            this.tb_todoInput.UseSystemPasswordChar = false;
            this.tb_todoInput.WatermarkText = "";
            // 
            // btn_addTodo
            // 
            this.btn_addTodo.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_addTodo.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_addTodo.DisabledForeColor = System.Drawing.Color.Gray;
            this.btn_addTodo.Font = new System.Drawing.Font("Segoe WP Light", 10F);
            this.btn_addTodo.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_addTodo.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btn_addTodo.HoverTextColor = System.Drawing.Color.White;
            this.btn_addTodo.IsDerivedStyle = true;
            this.btn_addTodo.Location = new System.Drawing.Point(466, 68);
            this.btn_addTodo.Name = "btn_addTodo";
            this.btn_addTodo.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_addTodo.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btn_addTodo.NormalTextColor = System.Drawing.Color.White;
            this.btn_addTodo.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_addTodo.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btn_addTodo.PressTextColor = System.Drawing.Color.White;
            this.btn_addTodo.Size = new System.Drawing.Size(180, 37);
            this.btn_addTodo.Style = MetroSet_UI.Enums.Style.Dark;
            this.btn_addTodo.StyleManager = this.styleManager1;
            this.btn_addTodo.TabIndex = 1;
            this.btn_addTodo.Text = "Add ToDo!";
            this.btn_addTodo.ThemeAuthor = "Narwin";
            this.btn_addTodo.ThemeName = "MetroDark";
            this.btn_addTodo.Click += new System.EventHandler(this.btn_addTodo_Click);
            // 
            // lb_todo1
            // 
            this.lb_todo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lb_todo1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lb_todo1.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lb_todo1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lb_todo1.Font = new System.Drawing.Font("Segoe WP Light", 10F);
            this.lb_todo1.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.lb_todo1.HoveredItemColor = System.Drawing.Color.DimGray;
            this.lb_todo1.IsDerivedStyle = true;
            this.lb_todo1.ItemHeight = 30;
            this.lb_todo1.Location = new System.Drawing.Point(3, 3);
            this.lb_todo1.MultiSelect = false;
            this.lb_todo1.Name = "lb_todo1";
            this.lb_todo1.SelectedIndex = -1;
            this.lb_todo1.SelectedItem = null;
            this.lb_todo1.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lb_todo1.SelectedItemColor = System.Drawing.Color.White;
            this.lb_todo1.SelectedText = null;
            this.lb_todo1.SelectedValue = null;
            this.lb_todo1.ShowBorder = false;
            this.lb_todo1.ShowScrollBar = false;
            this.lb_todo1.Size = new System.Drawing.Size(456, 343);
            this.lb_todo1.Style = MetroSet_UI.Enums.Style.Dark;
            this.lb_todo1.StyleManager = this.styleManager1;
            this.lb_todo1.TabIndex = 0;
            this.lb_todo1.ThemeAuthor = "Narwin";
            this.lb_todo1.ThemeName = "MetroDark";
            // 
            // completedToDos
            // 
            this.completedToDos.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.completedToDos.Font = null;
            this.completedToDos.ImageIndex = 0;
            this.completedToDos.ImageKey = null;
            this.completedToDos.IsDerivedStyle = true;
            this.completedToDos.Location = new System.Drawing.Point(4, 42);
            this.completedToDos.Name = "completedToDos";
            this.completedToDos.Size = new System.Drawing.Size(646, 342);
            this.completedToDos.Style = MetroSet_UI.Enums.Style.Dark;
            this.completedToDos.StyleManager = this.styleManager1;
            this.completedToDos.TabIndex = 1;
            this.completedToDos.Text = "Completed";
            this.completedToDos.ThemeAuthor = "Narwin";
            this.completedToDos.ThemeName = "MetroDark";
            this.completedToDos.ToolTipText = null;
            // 
            // prefpanel
            // 
            this.prefpanel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.prefpanel.Font = null;
            this.prefpanel.ImageIndex = 0;
            this.prefpanel.ImageKey = null;
            this.prefpanel.IsDerivedStyle = true;
            this.prefpanel.Location = new System.Drawing.Point(4, 42);
            this.prefpanel.Name = "prefpanel";
            this.prefpanel.Size = new System.Drawing.Size(646, 342);
            this.prefpanel.Style = MetroSet_UI.Enums.Style.Dark;
            this.prefpanel.StyleManager = this.styleManager1;
            this.prefpanel.TabIndex = 2;
            this.prefpanel.Text = "Preferences";
            this.prefpanel.ThemeAuthor = "Narwin";
            this.prefpanel.ThemeName = "MetroDark";
            this.prefpanel.ToolTipText = null;
            // 
            // mtd_helper
            // 
            this.mtd_helper.Cursor = System.Windows.Forms.Cursors.Hand;
            this.mtd_helper.Font = new System.Drawing.Font("Segoe WP Light", 10F);
            this.mtd_helper.IsDerivedStyle = true;
            this.mtd_helper.Location = new System.Drawing.Point(317, 58);
            this.mtd_helper.Name = "mtd_helper";
            this.mtd_helper.Size = new System.Drawing.Size(346, 23);
            this.mtd_helper.Style = MetroSet_UI.Enums.Style.Dark;
            this.mtd_helper.StyleManager = this.styleManager1;
            this.mtd_helper.TabIndex = 2;
            this.mtd_helper.Text = "Metro ToDo v.0.1beta";
            this.mtd_helper.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.mtd_helper.ThemeAuthor = "Narwin";
            this.mtd_helper.ThemeName = "MetroDark";
            this.mtd_helper.DoubleClick += new System.EventHandler(this.showAbout);
            // 
            // MainUI
            // 
            this.AllowResize = false;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(684, 501);
            this.Controls.Add(this.mtd_helper);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.mainTabs);
            this.Name = "MainUI";
            this.Padding = new System.Windows.Forms.Padding(12, 90, 12, 12);
            this.ShowTitle = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Style = MetroSet_UI.Enums.Style.Dark;
            this.StyleManager = this.styleManager1;
            this.Text = "Metro ToDo";
            this.TextColor = System.Drawing.Color.White;
            this.ThemeName = "MetroDark";
            this.mainTabs.ResumeLayout(false);
            this.mainToDo.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Components.StyleManager styleManager1;
        private MetroSet_UI.Controls.MetroSetTabControl mainTabs;
        private MetroSet_UI.Child.MetroSetSetTabPage mainToDo;
        private MetroSet_UI.Child.MetroSetSetTabPage completedToDos;
        private MetroSet_UI.Child.MetroSetSetTabPage prefpanel;
        private MetroSet_UI.Controls.MetroSetDivider todoDevider;
        private MetroSet_UI.Controls.MetroSetTextBox tb_todoInput;
        private MetroSet_UI.Controls.MetroSetButton btn_addTodo;
        private MetroSet_UI.Controls.MetroSetListBox lb_todo1;
        private MetroSet_UI.Controls.MetroSetButton btn_complete;
        private MetroSet_UI.Controls.MetroSetButton btn_edittodo;
        private MetroSet_UI.Controls.MetroSetButton btn_deltodo;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel mtd_helper;
    }
}

