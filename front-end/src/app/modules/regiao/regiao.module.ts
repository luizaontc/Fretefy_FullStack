import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegiaoComponent } from './regiao.component';
import { RegiaoRoutingModule } from './regiao.routing';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [RegiaoComponent],
  imports: [
    CommonModule,
    RegiaoRoutingModule,
    ReactiveFormsModule
  ],
  exports: [RegiaoComponent]
})
export class RegiaoModule { }
