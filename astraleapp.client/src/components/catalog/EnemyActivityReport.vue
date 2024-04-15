<script setup lang="ts">
import { defineProps, ref } from "vue"

defineProps(["title", "description"])

const activityReports = ref([
  { id: 0, title: "Prototype: IJN-I400", description: "Submersible Vessel Aircraft Carrier." }
])
</script>

<template>
  <EnemyActivityReport
    v-for="report in activityReports"
    :key="activityReports.id"
    :title="activityReports.title"
    :description="activityReports.description"
  />
</template>

<style scoped module="styles" lang="scss"></style>
