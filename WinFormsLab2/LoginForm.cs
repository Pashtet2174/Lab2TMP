namespace WinFormsLab2;
using UserLib;

public partial class LoginForm : Form
{
    private readonly IUserRepository _userRepository;
    public LoginForm(IUserRepository userRepository)
    {
        _userRepository = userRepository;   
        InitializeComponent();
    }

    private void cancel_Click(object sender, EventArgs e)
    {
        Password.Text = string.Empty;
        Namebox.Text = string.Empty;
    }

    private void Enter_Click(object sender, EventArgs e)
    {
        string username =  Namebox.Text;
        string password = Password.Text;
        IUser user = _userRepository.Authenticate(username, password);

        if (user != null)
        {
            Form1 mainForm = new Form1(user);
            mainForm.Show();
            
            this.Hide();
        }
        else
        {
            MessageBox.Show("Неверное имя пользователя или пароль!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
   
    

   