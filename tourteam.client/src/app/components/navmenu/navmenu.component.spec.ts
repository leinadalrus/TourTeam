import { ComponentFixture, TestBed } from '@angular/core/testing';

import { NavmenuComponent } from './navmenu.component';

describe('NavmenuComponent', () => {
  let component: NavmenuComponent;
  let fixture: ComponentFixture<NavmenuComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [NavmenuComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(NavmenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
