import { Routes } from '@angular/router';

import { DashboardComponent } from '../dashboard/dashboard.component';
import { UserProfileComponent } from '../components2/user-profile/user-profile.component';
import { TableListComponent } from '../components2/table-list/table-list.component';
import { TypographyComponent } from '../components2/typography/typography.component';
import { IconsComponent } from '../components2/icons/icons.component';
import { MapsComponent } from '../components2/maps/maps.component';
import { NotificationsComponent } from '../components2/notifications/notifications.component';
import { UpgradeComponent } from '../components2/upgrade/upgrade.component';

export const AdminLayoutRoutes: Routes = [
    { path: 'dashboard',      component: DashboardComponent },
    { path: 'user-profile',   component: UserProfileComponent },
    { path: 'table-list',     component: TableListComponent },
    { path: 'typography',     component: TypographyComponent },
    { path: 'icons',          component: IconsComponent },
    { path: 'maps',           component: MapsComponent },
    { path: 'notifications',  component: NotificationsComponent },
    { path: 'upgrade',        component: UpgradeComponent }
];
