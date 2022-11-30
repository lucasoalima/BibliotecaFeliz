import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ListarEmprestimoComponent } from './listar-emprestimo.component';

describe('ListarEmprestimoComponent', () => {
  let component: ListarEmprestimoComponent;
  let fixture: ComponentFixture<ListarEmprestimoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ ListarEmprestimoComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ListarEmprestimoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
