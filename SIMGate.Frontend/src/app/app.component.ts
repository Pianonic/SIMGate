import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { MenubarModule } from 'primeng/menubar';
import { AvatarModule } from 'primeng/avatar';
import { SplitterModule } from 'primeng/splitter';
import { InputTextModule } from 'primeng/inputtext';
import { FormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { ScrollerModule } from 'primeng/scroller';

type Contact = {
  name: string;
  mobileNumber: string;
};

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [RouterOutlet, MenubarModule, AvatarModule, SplitterModule, InputTextModule, FormsModule, ButtonModule, ScrollerModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.scss'
})
export class AppComponent {
  title = 'SIMGate.Frontend';
  message: string = "";

  firstNames: string[] = [
    "John", "Jane", "Michael", "Sarah", "David", "Emily", "Robert", "Olivia", 
    "James", "Sophia", "William", "Isabella", "Thomas", "Mia", "Daniel", 
    "Amelia", "Matthew", "Charlotte", "Joseph", "Ava"
  ];
  
  lastNames: string[] = [
    "Smith", "Johnson", "Williams", "Brown", "Jones", "Garcia", "Miller", 
    "Davis", "Rodriguez", "Martinez", "Hernandez", "Lopez", "Gonzalez", 
    "Wilson", "Anderson", "Thomas", "Taylor", "Moore", "Jackson", "Martin"
  ];
  
  contacts: Contact[] = Array.from({ length: 100 }, (_, i) => {
    const firstName = this.firstNames[i % this.firstNames.length];
    const lastName = this.lastNames[i % this.lastNames.length];
    return {
      name: `${firstName} ${lastName}`,
      mobileNumber: `555-00${i.toString().padStart(3, '0')}`,
    };
  });
}
