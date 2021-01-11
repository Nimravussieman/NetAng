import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './components9/counter/counter.component';
import { FetchDataComponent } from './components9/fetch-data/fetch-data.component';
import { DataComponent } from './components9/data/data.component';

import { ApiAuthorizationModule } from './api-authorization/api-authorization.module';
import { AuthorizeInterceptor } from './api-authorization/authorize.interceptor';
import { AuthorizeGuard } from './api-authorization/authorize.guard';

import { DashboardComponent } from '../app/dashboard/dashboard.component';

import { AdminLayoutModule } from '../app/admin-layout/admin-layout.module';
import { AdminLayoutComponent } from '../app/admin-layout/admin-layout.component';

import { FooterComponent } from '../app/components/footer/footer.component';
import { NavbarComponent } from '../app/components/navbar/navbar.component';
import { SidebarComponent } from '../app/components/sidebar/sidebar.component';
import { ComponentsModule } from '../app/components/components.module';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,

    //FooterComponent,
    //NavbarComponent,
    //SidebarComponent,

    //DashboardComponent,
    AdminLayoutComponent,

    DataComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    
    ApiAuthorizationModule,

    ComponentsModule,
    AdminLayoutModule,

    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'data', component: DataComponent, canActivate: [AuthorizeGuard] }
    ])
  ],
  providers: [
    { provide: HTTP_INTERCEPTORS, useClass: AuthorizeInterceptor, multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
