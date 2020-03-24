using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LV_1
{
    class Note
    {

        private String text;
        private String author;
        private int levelOfImportance;

        public String Author
        {
            get { return this.author; }
        }
        public String NoteText
        {
            get { return this.text; }
            set { this.text = value; }
        }
        public int ImportanceLVL
        {
            get { return this.levelOfImportance; }
            set { this.levelOfImportance = value; }
        }


        public Note()
        {
            this.text = "what";
            this.author = "Antonio";
            this.levelOfImportance = 1;
       
        }

        public Note(int importance)
        {
            this.text = "where";
            this.author = "Toni";
            this.levelOfImportance = importance;

        }

        public Note(string Text,string Author,int importance)
        {
            this.text = Text;
            this.author = Author;
            this.levelOfImportance = importance;

        }


        public string getText() { return this.text; }
        public string getAuthor() { return this.author; }
        public int getLevelOfImportance() { return this.levelOfImportance; }

        public void setText(string Text) { this.text = text; }
        public void setLevelOfImportance(int levelOfImportance) { this.levelOfImportance = levelOfImportance; }

        public override string ToString()
        {
            return "note: " + this.text+ ", " + "Author: " + this.author;
        }
    }

}

