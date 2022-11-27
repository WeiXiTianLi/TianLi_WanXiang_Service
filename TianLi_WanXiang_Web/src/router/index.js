import {VueRouter, createRouter,createWebHashHistory } from 'vue-router'
import {createApp} from 'vue'
import MainMap from '../components/MainMap'

const routes= [
        {
            path: '/',
            name: 'Home',
            component: () => import('../components/MainMap.vue')
        },
        {
            path: '/Map',
            name: 'Map',
            component: () => import('../components/MainMap.vue')
        },
        {
            path: '/Table',
            name: 'Table',
            component: () => import('../components/Table.vue')
        }
    ]

export const router = createRouter({
    history: createWebHashHistory(),
    routes: routes
})

