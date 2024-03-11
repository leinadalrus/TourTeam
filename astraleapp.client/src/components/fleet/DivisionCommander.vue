<script lang="ts">
import { defineComponent } from "vue"

type CommandInfo = {
  company: string
  division: string
  lastName: string
  firstName: string
}

interface CommandData {
  bound: boolean
  post: CommandInfo | null
}

export default defineComponent({
  data(): CommandData {
    return {
      bound: false,
      post: null
    }
  },
  methods: {
    fetchData(): void {
      this.bound = true
      this.post = null

      fetch("commander")
        .then((reader) => reader.json())
        .then((embed) => {
          this.bound = false
          this.post = embed as CommandInfo
        })
    }
  }
})
</script>

<template>
  <article></article>
</template>

<style scoped module="styles" lang="scss"></style>
