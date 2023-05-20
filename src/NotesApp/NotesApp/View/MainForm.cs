using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using NotesApp.Model;
using NotesApp.Model.Enums;

namespace NotesApp.View
{
    /// <summary>
    /// Создает главное окно.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// Перечисления категорий.
        /// </summary>
        private object[] _categories = Enum.GetNames(typeof(Category));
        
        /// <summary>
        /// Список записок.
        /// </summary>
        private List<Note> _notes;
        
        /// <summary>
        /// Текущая выбранная записка.
        /// </summary>
        private Note _currentNote;
        
        /// <summary>
        /// Создает экземпляр класса MainForm.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            
            DataBase.IsCreateFolderAndFile();
            _notes = DataBase.GetData();
            
            if (_notes.Count > 0)
            {
                foreach (var note in _notes)
                {
                    notesListBox.Items.Add(note.Title);
                }
            }
            
            categoryСomboBox.Items.AddRange(_categories);
        }
        
        /// <summary>
        /// Выбор элемента в notesListBox с последующим обновлением информации в TextBox.
        /// </summary>
        private void NotesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                _currentNote = _notes[notesListBox.SelectedIndex];
                editButton.Enabled = true;
                
                titleTextBox.Text = _currentNote.Title;
                descriptionTextBox.Text = _currentNote.Description;
                timeOfCreationTextBox.Text = _currentNote.Date;
                categoryСomboBox.Text = _currentNote.Category;
            }
            catch
            {
                editButton.Enabled = false;
            }
        }
        
        /// <summary>
        /// Событие добавления записки.
        /// </summary>
        private void AddNoteButton_Click(object sender, EventArgs e)
        {
            EnableAddButtonsEvents();
            DisableButtonsClicks();
            EnableVisibleButtons();
            EnableElements();
            ClearTextBox();
        }
        
        /// <summary>
        /// Событие, которое принимает добавление записки.
        /// </summary>
        private void AddNoteButtonAccept_Click(object sender, EventArgs e)
        {
            Note newNote = new Note(titleTextBox.Text, descriptionTextBox.Text, categoryСomboBox.Text);
            
            _notes.Insert(0, newNote);
            notesListBox.Items.Insert(0, newNote.Title);
            
            DataBase.UpdateData(_notes);
            
            DisableElements();
            DisableVisibleButtons();
            EnableButtonsClicks();
            ClearTextBox();
            DisableAddButtonsEvents();
        }
        
        /// <summary>
        /// Событие отмены добавления записки.
        /// </summary>
        private void AddNoteButtonCancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            notesListBox.SelectedIndex = -1;
            EnableButtonsClicks();
            DisableElements();
            DisableVisibleButtons();
            DisableAddButtonsEvents();
        }
        
        /// <summary>
        /// Событие изменения записки.
        /// </summary>
        private void EditNoteButton_Click(object sender, EventArgs e)
        {
            EnableEditButtonsEvents();
            DisableButtonsClicks();
            EnableVisibleButtons();
            EnableElements();
        }
        
        /// <summary>
        /// Событие, которое принимает изменения записки.
        /// </summary>
        private void EditNoteButtonAccept_Click(object sender, EventArgs e)
        {
            Note newNote = new Note(titleTextBox.Text, descriptionTextBox.Text, categoryСomboBox.Text);
            
            _notes.RemoveAt(notesListBox.SelectedIndex);
            _notes.Insert(0,newNote);
            notesListBox.Items.RemoveAt(notesListBox.SelectedIndex);
            notesListBox.Items.Insert(0, newNote.Title);
            
            DataBase.UpdateData(_notes);
            
            DisableElements();
            DisableVisibleButtons();
            EnableButtonsClicks();
            ClearTextBox();

            DisableEditButtonsEvents();
        }
        
        /// <summary>
        /// Событие отмены изменения записки.
        /// </summary>
        private void EditNoteButtonCancel_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            notesListBox.SelectedIndex = -1;
            EnableButtonsClicks();
            DisableElements();
            DisableVisibleButtons();
            DisableEditButtonsEvents();
        }
        
        /// <summary>
        /// Событие удаления записки.
        /// </summary>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _notes.RemoveAt(notesListBox.SelectedIndex);
                notesListBox.Items.RemoveAt(notesListBox.SelectedIndex);
                DataBase.UpdateData(_notes);
                ClearTextBox();
            }
            catch
            {
                // ignored
            }
        }
        
        /// <summary>
        /// Включение всех элементов в groupBox.
        /// </summary>
        private void EnableElements()
        {
            notesListBox.Enabled = false;
            titleTextBox.Enabled = true;
            descriptionTextBox.Enabled = true;
            categoryСomboBox.Enabled= true;
        }

        /// <summary>
        /// Отключение всех элементов groupBox.
        /// </summary>
        private void DisableElements()
        {
            notesListBox.Enabled = true;
            titleTextBox.Enabled = false;
            descriptionTextBox.Enabled = false;
            categoryСomboBox.Enabled = false;
        }

        /// <summary>
        /// Очистка всех полей.
        /// </summary>
        private void ClearTextBox()
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
            timeOfCreationTextBox.Text = "";
            categoryСomboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Включение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void EnableVisibleButtons()
        {
            timeOfCreationTextBox.Visible = false;
            timeOfCreationLabel.Visible = false;
            cancelButton.Visible = true;
            acceptButton.Visible = true;
        }
        
        /// <summary>
        /// Отключение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void DisableVisibleButtons()
        {
            timeOfCreationTextBox.Visible = true;
            timeOfCreationLabel.Visible = true;
            cancelButton.Visible = false;
            acceptButton.Visible = false;
        }

        /// <summary>
        /// Включение нажатий кнопок addButton и deleteButton.
        /// </summary>
        private void EnableButtonsClicks()
        {
            addButton.Enabled = true;
            deleteButton.Enabled = true;
        }

        /// <summary>
        /// Отключение нажатий кнопок addButton и deleteButton.
        /// </summary>
        private void DisableButtonsClicks()
        {
            addButton.Enabled = false;
            deleteButton.Enabled = false;
        }

        /// <summary>
        /// Включение событий кнопки добавить.
        /// </summary>
        private void EnableAddButtonsEvents()
        {
            acceptButton.Click += AddNoteButtonAccept_Click;
            cancelButton.Click += AddNoteButtonCancel_Click; 
        }

        /// <summary>
        /// Отключение событий кнопки добавить.
        /// </summary>
        private void DisableAddButtonsEvents()
        {
            cancelButton.Click -= AddNoteButtonCancel_Click;
            acceptButton.Click -= AddNoteButtonAccept_Click;
        }
        
        /// <summary>
        /// Включение событий кнопки изменить.
        /// </summary>
        private void EnableEditButtonsEvents()
        {
            acceptButton.Click += EditNoteButtonAccept_Click;
            cancelButton.Click += EditNoteButtonCancel_Click; 
        }

        /// <summary>
        /// Отключение событий кнопки изменить.
        /// </summary>
        private void DisableEditButtonsEvents()
        {
            acceptButton.Click -= EditNoteButtonAccept_Click;
            cancelButton.Click -= EditNoteButtonCancel_Click; 
        }

        /// <summary>
        /// Валидация titleTextBox на количество символов.
        /// </summary>
        private void TitleTextBox_TextChanged(object sender, EventArgs e)
        {
            if (titleTextBox.Text.Length > 50)
            {
                acceptButton.Enabled = false;
                titleTextBox.BackColor = Color.Red;
            }
            else if (titleTextBox.Text.Length == 0)
            {
                acceptButton.Enabled = false;
                titleTextBox.BackColor = Color.White;
            }
            else
            {
                acceptButton.Enabled = true;
                titleTextBox.BackColor = Color.White;
            }
        }
    }
}