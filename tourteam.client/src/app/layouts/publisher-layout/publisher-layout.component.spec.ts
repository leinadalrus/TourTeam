import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PublisherLayoutComponent } from './publisher-layout.component';

describe('PublisherLayoutComponent', () => {
  let component: PublisherLayoutComponent;
  let fixture: ComponentFixture<PublisherLayoutComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [PublisherLayoutComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(PublisherLayoutComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
