<script setup lang="ts">
import { ref } from "vue"
import { defineStore } from "pinia"
import EnemyActivityReport from "./EnemyActivityReport.vue"
import useShipsBoatsStore from "../ships/useShipsBoatsStore.vue";
</script>

<template>
  <OrderOfBattle>
    <EnemyActivityReport />
  </OrderOfBattle>
</template>

<style scoped module="styles" lang="scss"></style>
