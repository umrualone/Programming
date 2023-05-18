using System;
using System.Collections.Generic;
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
        private object[] categories = Enum.GetNames(typeof(Category));
        
        /// <summary>
        /// Подключение данных файла.
        /// </summary>
        private static DataBase _file = new DataBase(@"Notes.json");
        
        /// <summary>
        /// Список записок.
        /// </summary>
        private List<Note> _notes = _file.GetData();
        
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
            
            if (_notes.Count > 0)
            {
                foreach (var note in _notes)
                {
                    notesListBox.Items.Add(note.Title);
                }
            }
            
            categoryСomboBox.Items.AddRange(categories);
        }
        
        /// <summary>
        /// Выбор элемента в notesListBox с последующим обновлением информации в TextBox.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNoteButtonAccept_Click(object sender, EventArgs e)
        {
            Note newNote = new Note(titleTextBox.Text, descriptionTextBox.Text, categoryСomboBox.Text);
            
            _notes.Insert(0, newNote);
            notesListBox.Items.Insert(0, newNote.Title);
            
            _file.UpdateData(_notes);
            
            DisableElements();
            DisableVisibleButtons();
            EnableButtonsClicks();
            ClearTextBox();
            DisableAddButtonsEvents();
        }
        
        /// <summary>
        /// Событие отмены добавления записки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditNoteButtonAccept_Click(object sender, EventArgs e)
        {
            Note newNote = new Note(titleTextBox.Text, descriptionTextBox.Text, categoryСomboBox.Text);
            
            _notes.RemoveAt(notesListBox.SelectedIndex);
            _notes.Insert(0,newNote);
            notesListBox.Items.RemoveAt(notesListBox.SelectedIndex);
            notesListBox.Items.Insert(0, newNote.Title);
            
            _file.UpdateData(_notes);
            
            DisableElements();
            DisableVisibleButtons();
            EnableButtonsClicks();
            ClearTextBox();

            DisableEditButtonsEvents();
        }
        
        /// <summary>
        /// Событие отмены изменения записки.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteNoteButton_Click(object sender, EventArgs e)
        {
            try
            {
                _notes.RemoveAt(notesListBox.SelectedIndex);
                notesListBox.Items.RemoveAt(notesListBox.SelectedIndex);
                _file.UpdateData(_notes);
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
            titleTextBox.ReadOnly = false;
            descriptionTextBox.ReadOnly = false;
            categoryСomboBox.Enabled = true;
        }

        /// <summary>
        /// Отключение всех элементов groupBox.
        /// </summary>
        private void DisableElements()
        {
            notesListBox.Enabled = true;
            titleTextBox.ReadOnly = true;
            descriptionTextBox.ReadOnly = true;
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
            cancelButton.Visible = true;
            acceptButton.Visible = true;
        }
        
        /// <summary>
        /// Отключение видимости кнопок cancelButton и acceptButton.
        /// </summary>
        private void DisableVisibleButtons()
        {
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
    }
}