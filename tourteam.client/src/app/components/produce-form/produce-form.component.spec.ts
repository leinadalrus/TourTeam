import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ProduceFormComponent } from './produce-form.component';

describe('ProduceFormComponent', () => {
  let component: ProduceFormComponent;
  let fixture: ComponentFixture<ProduceFormComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ProduceFormComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ProduceFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
