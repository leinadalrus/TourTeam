<script setup lang="ts">
import { defineStore } from "pinia"
import { ref } from "vue"
import ShipCommand from "./ShipCommand.vue"

const useShipsBoatsStore = defineStore("ship", () => {
  const ShipRegistryID = ref(0)
  const ShipCaptain = ref(0) // denote by UUID
  const ShipStaff = ref(0) // denote by UUID

  const ShipTypePrefix = ref("")
  const ShipDivision = ref("")
  const ShipName = ref("")

  return {
    ShipRegistryID,
    ShipCaptain,
    ShipStaff,
    ShipTypePrefix,
    ShipDivision,
    ShipName
  }
})
</script>

<template>
  <article>
    <!-- to-fix: code ... -->
  </article>
</template>

<style scoped module="styles" lang="scss"></style>
