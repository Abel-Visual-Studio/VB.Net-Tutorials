OpenFileDialog1.ShowDialog()
Dim File = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
RichTextBox1.Text = File.ToString
