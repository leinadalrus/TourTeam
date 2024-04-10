<script setup lang="ts">
import { defineProps, ref } from "vue"

defineProps(["title", "description"])

const _activityReports = ref([
  { id: 0, title: "Prototype: IJN-I400", description: "Submersible Vessel Aircraft Carrier." }
])
</script>

<template>
  <EnemyActivityReport
    v-for="report in _activityReports"
    :key="_activityReports.id"
    :title="_activityReports.title"
    :description="_activityReports.description"
  />
</template>

<style scoped module="styles" lang="scss"></style>
