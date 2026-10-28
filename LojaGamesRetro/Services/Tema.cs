namespace LojaGamesRetro.Services
{
    // cores e estilos que todas as telas usam
    public static class Tema
    {
        public static readonly Color Fundo = Color.FromArgb(24, 20, 37);
        public static readonly Color Painel = Color.FromArgb(38, 32, 58);
        public static readonly Color Card = Color.FromArgb(50, 43, 76);
        public static readonly Color Destaque = Color.FromArgb(255, 64, 129);
        public static readonly Color Secundaria = Color.FromArgb(0, 229, 255);
        public static readonly Color Sucesso = Color.FromArgb(118, 255, 3);
        public static readonly Color Texto = Color.FromArgb(235, 235, 245);
        public static readonly Color TextoSuave = Color.FromArgb(170, 165, 195);

        public static readonly Font Titulo = new("Consolas", 22F, FontStyle.Bold);
        public static readonly Font Subtitulo = new("Consolas", 12F, FontStyle.Bold);
        public static readonly Font Normal = new("Segoe UI", 10F);

        public static void EstilizarBotao(Button botao, Color cor)
        {
            botao.FlatStyle = FlatStyle.Flat;
            botao.FlatAppearance.BorderSize = 0;
            botao.FlatAppearance.MouseOverBackColor = ControlPaint.Light(cor, 0.3f);
            botao.BackColor = cor;
            botao.ForeColor = Fundo;
            botao.Font = new Font("Consolas", 10F, FontStyle.Bold);
            botao.Cursor = Cursors.Hand;
        }

        public static void EstilizarGrid(DataGridView grid)
        {
            grid.BackgroundColor = Painel;
            grid.BorderStyle = BorderStyle.None;
            grid.GridColor = Card;
            grid.EnableHeadersVisualStyles = false;
            grid.ColumnHeadersDefaultCellStyle.BackColor = Card;
            grid.ColumnHeadersDefaultCellStyle.ForeColor = Secundaria;
            grid.ColumnHeadersDefaultCellStyle.Font = new Font("Consolas", 10F, FontStyle.Bold);
            grid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Card;
            grid.DefaultCellStyle.BackColor = Painel;
            grid.DefaultCellStyle.ForeColor = Texto;
            grid.DefaultCellStyle.SelectionBackColor = Destaque;
            grid.DefaultCellStyle.SelectionForeColor = Color.White;
            grid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(44, 38, 66);
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.ReadOnly = true;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
