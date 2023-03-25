using TextTransformer.UI.Extensions;

namespace LyricFormatter;

partial class MainForm
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
        sourceTextBox = new SynchronizedVScrollTextBox();
        groupBox1 = new GroupBox();
        groupBox2 = new GroupBox();
        transformedTextBox = new SynchronizedVScrollTextBox();
        formatButton = new Button();
        copyToClipboardButton = new Button();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // sourceTextBox
        // 
        sourceTextBox.Dock = DockStyle.Fill;
        sourceTextBox.Location = new Point(3, 19);
        sourceTextBox.Multiline = true;
        sourceTextBox.Name = "sourceTextBox";
        sourceTextBox.ScrollBars = ScrollBars.Vertical;
        sourceTextBox.Size = new Size(379, 294);
        sourceTextBox.TabIndex = 0;
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(sourceTextBox);
        groupBox1.Location = new Point(12, 12);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new Size(385, 316);
        groupBox1.TabIndex = 1;
        groupBox1.TabStop = false;
        groupBox1.Text = "Source";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(transformedTextBox);
        groupBox2.Location = new Point(403, 12);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new Size(385, 316);
        groupBox2.TabIndex = 2;
        groupBox2.TabStop = false;
        groupBox2.Text = "Formatted";
        // 
        // transformedTextBox
        // 
        transformedTextBox.Dock = DockStyle.Fill;
        transformedTextBox.Location = new Point(3, 19);
        transformedTextBox.Multiline = true;
        transformedTextBox.Name = "transformedTextBox";
        transformedTextBox.ReadOnly = true;
        transformedTextBox.ScrollBars = ScrollBars.Vertical;
        transformedTextBox.Size = new Size(379, 294);
        transformedTextBox.TabIndex = 0;
        // 
        // formatButton
        // 
        formatButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        formatButton.Location = new Point(130, 331);
        formatButton.Name = "formatButton";
        formatButton.Size = new Size(149, 40);
        formatButton.TabIndex = 3;
        formatButton.Text = "Format";
        formatButton.UseVisualStyleBackColor = true;
        formatButton.Click += formatButton_Click;
        // 
        // copyToClipboardButton
        // 
        copyToClipboardButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
        copyToClipboardButton.Location = new Point(521, 331);
        copyToClipboardButton.Name = "copyToClipboardButton";
        copyToClipboardButton.Size = new Size(149, 40);
        copyToClipboardButton.TabIndex = 4;
        copyToClipboardButton.Text = "Copy to Clipboard";
        copyToClipboardButton.UseVisualStyleBackColor = true;
        copyToClipboardButton.Click += copyToClipboardButton_Click;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 383);
        Controls.Add(copyToClipboardButton);
        Controls.Add(formatButton);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        Name = "MainForm";
        Text = "Text Transformer";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private SynchronizedVScrollTextBox sourceTextBox;
    private GroupBox groupBox1;
    private GroupBox groupBox2;
    private SynchronizedVScrollTextBox transformedTextBox;
    private Button formatButton;
    private Button copyToClipboardButton;
}